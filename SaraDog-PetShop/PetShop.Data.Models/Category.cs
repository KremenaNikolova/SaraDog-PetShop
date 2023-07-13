namespace PetShop.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using static PetShop.Common.ValidationConstants.CategoryValidationConstants;

    public class Category
    {
        public Category()
        {
            Items = new HashSet<Item>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; } = null!;

        public virtual ICollection<Item> Items { get; set; } 

        [Required]
        [MaxLength(ImageMaxLength)]
        public string Image { get; set; } = null!;


    }
}
