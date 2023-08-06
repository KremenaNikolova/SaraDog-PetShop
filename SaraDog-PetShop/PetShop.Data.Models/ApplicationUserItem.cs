namespace PetShop.Data.Models
{
    using System.ComponentModel.DataAnnotations.Schema;

    public class ApplicationUserItem
    {
        [ForeignKey(nameof(User))]
        public Guid UserId { get; set; }

        public virtual ApplicationUser User { get; set; } = null!;

        [ForeignKey(nameof(Item))]
        public int ItemId { get; set; }

        public virtual Item Item { get; set; } = null!;
    }
}
