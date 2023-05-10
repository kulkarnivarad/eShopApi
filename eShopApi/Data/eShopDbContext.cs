using eShopApi.Models;
using Microsoft.EntityFrameworkCore;

namespace eShopApi.Data
{
    public class eShopDbContext : DbContext
    {
        public eShopDbContext(DbContextOptions<eShopDbContext> options) : base(options)
        { }
       
        public DbSet<UserDetail> UserDetails { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Payment> Payment { get; set; }
        public DbSet<Cart> Carts { get; set; }

        public DbSet<Order> Orders { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
    }
}
