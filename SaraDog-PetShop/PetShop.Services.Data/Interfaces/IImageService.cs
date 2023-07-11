namespace PetShop.Services.Data.Interfaces
{
    using Microsoft.AspNetCore.Http;

    public interface IImageService
    {
        Task<Tuple<int, string>> SaveImage(IFormFile imageFile);

        Task<Stream> GetImageStreamAsync(string imageName);
    }
}
