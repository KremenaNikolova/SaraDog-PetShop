namespace PetShop.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using static PetShop.Common.ValidationConstants.CategoryValidation;

    public class Category
    {
        public Category()
        {
            IsDeleted = false;
            
            Items = new HashSet<Item>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; } = null!;

        [Required]
        [MaxLength(ImageMaxLength)]
        public string Image { get; set; } = null!;

        public bool IsDeleted { get; set; }

        public virtual ICollection<Item> Items { get; set; } 

    }
}
