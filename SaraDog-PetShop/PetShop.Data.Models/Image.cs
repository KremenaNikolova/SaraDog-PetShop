using System.ComponentModel.DataAnnotations;

namespace PetShop.Data.Models
{
    public class Image
    {
        public int Id { get; set; }

        [Required]
        public string Data { get; set; } = null!;
    }
}
