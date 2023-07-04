namespace PetShop.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using static PetShop.Common.ValidationConstants.CategoryValidationConstants;

    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; } = null!;

        public bool? IsDeleted { get; set; }

        public virtual ICollection<Item> Items { get; set; } = new HashSet<Item>();


    }
}
