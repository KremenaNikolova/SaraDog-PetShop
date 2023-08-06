namespace PetShop.Services.Data.Interfaces
{
    using Microsoft.AspNetCore.Http;
    
    using PetShop.Web.ViewModels.Home;

    public interface IImageService
    {
        Task<Tuple<int, string>> SaveImage(IFormFile imageFile);

        Task<Stream> GetImageStreamAsync(string imageName);

        LandingPageModel GetLandingPageImage();

        Task<string> DownloadImageAsync(string imageName);
    }
}
