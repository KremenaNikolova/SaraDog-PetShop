using System.ComponentModel.DataAnnotations.Schema;

namespace PetShop.Data.Models
{
    public class ApplicationUserItem
    {
        [ForeignKey(nameof(User))]
        public Guid UserId { get; set; }

        public ApplicationUser User { get; set; } = null!;

        [ForeignKey(nameof(Item))]
        public int ItemId { get; set; }

        public Item Item { get; set; } = null!;
    }
}
