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

        [Display(Name = "Заглавие")]
        [Required]
        public string Title { get; set; } = null!;

        [Display(Name = "Цена")]
        public decimal Price { get; set; }

        [Required]
        [Display(Name = "Снимка")]
        public string Image { get; set; } = null!;

    }
}
