namespace PetShop.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using static PetShop.Common.ValidationConstants.ItemValidationConstants;

    public class Item
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(TitleMaxLength)]
        public string Title { get; set; } = null!;

        [Required]
        [MaxLength(ImageMaxLength)]
        public string TitleImage { get; set; } = null!;

        [Required]
        [MaxLength(DescriptionMaxLength)]
        public string Description { get; set; } = null!;

        public decimal Price { get; set; }

        public DateTime AddedOn { get; set; } = DateTime.UtcNow;

        public decimal? Rating { get; set; }

        [ForeignKey(nameof(Category))]
        public int CategoryId { get; set; }

        [Required]
        public virtual Category Category { get; set; } = null!;

        public virtual ICollection<ApplicationUserItem> UserItems { get; set; } = new HashSet<ApplicationUserItem>();


    }
}