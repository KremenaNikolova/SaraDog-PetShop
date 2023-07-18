namespace PetShop.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class CartItem
    {
        [ForeignKey(nameof(Item))]
        public int ItemId { get; set; }

        [Required]
        public Item Item { get; set; } = null!;

        [ForeignKey(nameof(Cart))]
        public Guid CartId { get; set; }

        [Required]
        public Cart Cart { get; set; } = null!;
    }
}
