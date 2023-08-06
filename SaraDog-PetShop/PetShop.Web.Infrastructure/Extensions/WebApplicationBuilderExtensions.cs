namespace PetShop.Web.Infrastructure.Extensions
{
    using System.Reflection;
    
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.Extensions.DependencyInjection;
    
    using PetShop.Data.Models;

    using static PetShop.Common.ApplicationConstants;

    public static class WebApplicationBuilderExtensions
    {
        /// <summary>
        /// This method registers all services with their interfaces and implementations of given assembly.
        /// The assembly is taken from the type of random service implementation provided.
        /// </summary>
        /// <param name="serviceType">Type of random service implementation.</param>
        /// <exception cref="InvalidOperationException"></exception>

        public static void AddApplicationServices(this IServiceCollection services, Type serviceType)
        {
            Assembly? serviceAssembly = Assembly.GetAssembly(serviceType);
            if (serviceAssembly == null)
            {
                throw new InvalidOperationException("Invalid service type provided!");
            }

            Type[] sType = serviceAssembly
                .GetTypes()
                .Where(st => st.Name.EndsWith("Service") && !st.IsInterface)
                .ToArray();

            foreach (Type st in sType)
            {
                var interfaceType = st
                    .GetInterface($"I{st.Name}");

                if (interfaceType == null)
                {
                    throw new InvalidOperationException($"No interface is provided for the service with name {st.Name}");
                }

                services.AddScoped(interfaceType, st);
            }

        }

        public static IApplicationBuilder SeedRoles(this IApplicationBuilder app)
        {
            using IServiceScope scopedServices = app.ApplicationServices.CreateScope();

            var roleManager = scopedServices.ServiceProvider.GetRequiredService<RoleManager<IdentityRole<Guid>>>();

            var roles = new[] { "Admin", "Moderator", "User" };

            Task.Run(async () =>
            {
                foreach (var role in roles)
                {
                    if (!await roleManager.RoleExistsAsync(role))
                    {
                        await roleManager.CreateAsync(new IdentityRole<Guid>(role));
                    }
                }
            })
            .GetAwaiter()
            .GetResult();

            return app;
        }

        public static IApplicationBuilder SeedAdministrator(this IApplicationBuilder app)
        {
            using IServiceScope scopedServices = app.ApplicationServices.CreateScope();

            var userManager = scopedServices.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();

            string username = AdministratorUsername;
            string email = AdministratorEmail;
            string password = AdministratorPassword;
            string role = AdministratorRole;

            Task.Run(async () =>
            {
                if (await userManager.FindByEmailAsync(email) == null)
                {
                    var user = new ApplicationUser();

                    await userManager.SetUserNameAsync(user, username);
                    await userManager.SetEmailAsync(user, email);

                    await userManager.CreateAsync(user, password);

                    await userManager.AddToRoleAsync(user, role);
                }
            })
            .GetAwaiter()
            .GetResult();

            return app;
        }
    }
}
