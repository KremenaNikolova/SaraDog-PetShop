namespace PetShop.Services.Data
{
    using Azure.Core;
    using Azure.Storage.Blobs.Models;
    using Azure.Storage.Blobs;
    using Microsoft.AspNetCore.Http;
    using PetShop.Services.Data.Interfaces;
    using PetShop.Web.Data;
    using Microsoft.Extensions.Configuration;
    using PetShop.Web.ViewModels.Home;

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
                return new Tuple<int, string>(0, "Възникна неочаквана грешка по време на запазване на снимката!");
            }
        }

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
                throw new InvalidOperationException("Възникна неочаквана грешка при взимането на картинката!");
            }
        }

        public LandingPageModel GetLandingPageImageAsync()
        {
            var landingImageModel = new LandingPageModel()
            {
                LandingImage = "CroppedWorkout.jpg"
            };

            return landingImageModel;
        }

    }
}
