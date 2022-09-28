using Pizzeria.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace Pizzeria.Repositories
{
    public class AppDbContext : IdentityDbContext<User, Role, int>
    {
        //needed for migration
        public AppDbContext()
        {

        }
        //configuration from settings
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<ItemType> ItemTypes { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<PaymentDetails> PaymentDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //needed for migration
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"data source=.; initial catalog=PizzeriaSite;integrated security=True;");

               // optionsBuilder.UseSqlServer(@"data source=.; initial catalog=PizzeriaSite;persist security info=True;user id=sa;password=Sudhu@123;");
            }
            base.OnConfiguring(optionsBuilder);
        }
    }
}
