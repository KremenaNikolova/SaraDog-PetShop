﻿namespace PetShop.Data.Models
{
    using Microsoft.AspNetCore.Identity;

    public class ApplicationUser : IdentityUser<Guid>
    {
        public ApplicationUser()
        {
            Id = Guid.NewGuid();

            IsModerator = false;
            IsDeleted = false;

            Orders = new HashSet<Order>();
        }

        public string? Address { get; set; }

        public bool IsModerator { get; set; }

        public bool IsDeleted { get; set; }

        public ICollection<Order> Orders { get; set; }

    }
}
