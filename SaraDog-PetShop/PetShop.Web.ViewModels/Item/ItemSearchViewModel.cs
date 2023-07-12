namespace PetShop.Web.ViewModels.Item
{
    using Microsoft.AspNetCore.Http;
    using PetShop.Common;
    using PetShop.Web.ViewModels.Category;
    using System.ComponentModel.DataAnnotations;
    using System.Xml.Linq;

    public class ItemSearchViewModel
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; } = null!;

        public decimal Price { get; set; }

        [Required]
        public string Image { get; set; } = null!;

    }
}
