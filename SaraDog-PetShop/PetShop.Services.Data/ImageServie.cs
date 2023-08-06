namespace PetShop.Services.Data
{
    using Microsoft.AspNetCore.Http;
    using Microsoft.Extensions.Configuration;

    using Azure.Core;
    using Azure.Storage.Blobs;
    using Azure.Storage.Blobs.Models;

    using PetShop.Services.Data.Interfaces;
    using PetShop.Web.Data;
    using PetShop.Web.ViewModels.Home;

    using static PetShop.Common.ApplicationConstants;

    public class ImageService : IImageService
    {
        private readonly PetShopDbContext dbContext;

        private readonly IConfiguration configuration;

        public ImageService(PetShopDbContext dbContext, IConfiguration configuration)
        {
            this.dbContext = dbContext;
            this.configuration = configuration;

        }

        public async Task<Tuple<int, string>> SaveImage(IFormFile imageFile)
        {
            try
            {
                var connectionString = configuration.GetConnectionString("AzureConnection");
                var containerName = "saradogimages";

                var blobServiceClient = new BlobServiceClient(connectionString);
                var containerClient = blobServiceClient.GetBlobContainerClient(containerName);

                var fileName = Path.GetFileName(imageFile.FileName);
                var blobClientOptions = new BlobClientOptions
                {
                    Diagnostics = { IsLoggingEnabled = false },
                    Retry =
                    {
                        Mode = RetryMode.Exponential,
                        Delay = TimeSpan.FromSeconds(3),
                        MaxRetries = 3,
                        MaxDelay = TimeSpan.FromSeconds(30)
                    }
                };

                var blobClient = containerClient.GetBlobClient(fileName);

                using (var stream = imageFile.OpenReadStream())
                {
                    await blobClient.UploadAsync(stream, new BlobUploadOptions(), cancellationToken: default);
                }

                return new Tuple<int, string>(1, fileName);
            }
            catch
            {
                return new Tuple<int, string>(0, "An unexpected error occurred while uploading a picture! Please, try again.");
            }

        }

        /// <summary>
        /// We need from this method for HomeController Action "GetImage" to for directly using pictures from Azure Storage for view pages as src="@Url.Action("GetImage", "Home", new { imageName = category.Image })"
        /// At this moment we are downaloding all pictures and use it localy because no money for proper acount :D
        /// </summary>
        public async Task<Stream> GetImageStreamAsync(string imageName)
        {
            try
            {
                var connectionString = configuration.GetConnectionString("AzureConnection");
                var containerName = "saradogimages";

                var blobServiceClient = new BlobServiceClient(connectionString);
                var containerClient = blobServiceClient.GetBlobContainerClient(containerName);

                var blobClient = containerClient.GetBlobClient(imageName);

                var response = await blobClient.DownloadAsync();

                return response.Value.Content;
            }
            catch
            {
                throw new InvalidOperationException("An unexpected error occurred with loading a picture! Please, try again.");
            }
        }

        public LandingPageModel GetLandingPageImage()
        {
            var landingImageModel = new LandingPageModel()
            {
                LandingImage = LandingPageImageTitle
            };

            return landingImageModel;
        }

        public async Task<string> DownloadImageAsync(string imageName)
        {
            var connectionString = configuration.GetConnectionString("AzureConnection");
            BlobServiceClient blobServiceClient = new BlobServiceClient(connectionString);

            string localFilePath = Path.Combine("wwwroot/Images", imageName);

            if (!File.Exists(localFilePath))
            {
                var containerName = "saradogimages";
                BlobContainerClient containerClient = blobServiceClient.GetBlobContainerClient(containerName);
                BlobClient blobClient = containerClient.GetBlobClient(imageName);

                BlobDownloadInfo downloadInfo = await blobClient.DownloadAsync();

                using FileStream stream = File.OpenWrite(localFilePath);
                await downloadInfo.Content.CopyToAsync(stream);
            }

            return localFilePath;
        }

    }
}
