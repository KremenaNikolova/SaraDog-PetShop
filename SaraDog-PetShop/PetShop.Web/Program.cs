namespace PetShop.Web
{
    using Microsoft.EntityFrameworkCore;

    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Identity;

    using Data;
    using PetShop.Data.Models;
    using PetShop.Web.Infrastructure.Extensions;
    using PetShop.Services.Data.Interfaces;
    using PetShop.Web.Infrastructure.ModelBinder;

    using static PetShop.Common.ApplicationConstants;

    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");

            builder.Services.AddDbContext<PetShopDbContext>(options =>
                options.UseSqlServer(connectionString));

            builder.Services.AddDatabaseDeveloperPageExceptionFilter();

            builder.Services.AddDefaultIdentity<ApplicationUser>(options =>
            {
                options.SignIn.RequireConfirmedAccount = false;

                options.Password.RequireLowercase = true;
                options.Password.RequireUppercase = true;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequiredLength = PasswordMinLength;

                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromSeconds(10);
                options.Lockout.MaxFailedAccessAttempts = MaxFailedAccessAttemptsConst;
            })
                .AddRoles<IdentityRole<Guid>>()
                .AddEntityFrameworkStores<PetShopDbContext>();

            builder.Services.AddControllersWithViews();

            //builder.Services.AddMemoryCache();
            //builder.Services.AddSession();

            builder.Services.AddApplicationServices(typeof(IItemService));

            builder.Services.ConfigureApplicationCookie(cfg =>
            {
                cfg.LoginPath = "/User/Login";
                cfg.LogoutPath = "/User/Logout";
                cfg.AccessDeniedPath = "/Home/Error?statusCode=401";
            });

            builder.Services.AddControllersWithViews()
                .AddMvcOptions(options =>
                {
                    options.ModelBinderProviders.Insert(0, new DecimalModelBinderProvider());
                    //options.Filters.Add<AutoValidateAntiforgeryTokenAttribute>();
                });

            var app = builder.Build();


            if (app.Environment.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseMigrationsEndPoint();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error?statusCode=500");
                app.UseStatusCodePagesWithRedirects("/Home/Error?statusCode={0}");

                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.SeedRoles();
            app.SeedAdministrator();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                  name: "Admin",
                  pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
                );

                endpoints.MapControllerRoute(
               name: "default",
               pattern: "{controller=Home}/{action=Index}/{id?}");

                //endpoints.MapDefaultControllerRoute();

            });

            app.MapRazorPages();

            await app.RunAsync();
        }
    }
}