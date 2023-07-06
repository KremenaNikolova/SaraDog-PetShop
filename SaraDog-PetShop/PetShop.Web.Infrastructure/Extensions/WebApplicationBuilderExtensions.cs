namespace PetShop.Web.Infrastructure.Extensions
{
    using Microsoft.Extensions.DependencyInjection;

    using System.Reflection;

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
                .Where(st=>st.Name.EndsWith("Service") && !st.IsInterface)
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
    }
}
