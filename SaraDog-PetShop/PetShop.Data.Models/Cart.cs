namespace PetShop.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Cart
    {
        public Cart()
        {
            Id = Guid.NewGuid();
            CreatedOn = DateTime.UtcNow;

            CartItems = new HashSet<CartItem>();
        }

        [Key]
        public Guid Id { get; set; }

        [ForeignKey(nameof(User))]
        public Guid UserId { get; set; }

        [Required]
        public virtual ApplicationUser User { get; set; } = null!;

        public DateTime CreatedOn { get; set; }

        public virtual ICollection<CartItem> CartItems { get; set; }

    }
}
