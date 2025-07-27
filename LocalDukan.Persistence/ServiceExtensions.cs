using LocalDukan.Domain.Entities;
using LocalDukan.Persistence.Context;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace LocalDukan.Persistence
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            // Register the DbContext with the connection string from configuration
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));

            // Use AddIdentityCore instead of AddIdentity to resolve the error
            services.AddIdentityCore<ApplicationUserEntity>(options => { })
                .AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>();
                //.AddDefaultTokenProviders(); // Ensure the correct namespace is included

            // Register repositories and other services here
            // Example: services.AddScoped<IProductRepository, ProductRepository>();
            return services;
        }
    }
}
