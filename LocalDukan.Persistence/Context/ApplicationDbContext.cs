using LocalDukan.Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace LocalDukan.Persistence.Context
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUserEntity>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        //public DbSet<User> Users { get; set; }
        public DbSet<ProductEntity> Products { get; set; }
        //public DbSet<CartItem> CartItems { get; set; }
        public DbSet<OrdersEntity> Orders { get; set; }
        //public DbSet<Address> Addresses { get; set; }
    }
}
