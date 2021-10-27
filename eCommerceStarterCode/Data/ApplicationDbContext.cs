using eCommerceStarterCode.Configuration;
using eCommerceStarterCode.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace eCommerceStarterCode.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions options)
            :base(options)
        {

        }

        public DbSet<Rating> Ratings { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Car>()
                .HasData(
                new Car { Id = 1, Price = 24000, Make = "Ford", Model = "Fusion", Description = "Entry level sedan", Mileage = 25000, AverageRating = 3.5 },
                new Car { Id = 2, Price = 20000, Make = "Dodge", Model = "Durango", Description = "Used 2015 Dodge Durango", Mileage = 95000, AverageRating = 3.7 },
                new Car { Id = 3, Price = 45000, Make = "Chevrolet", Model = "Tahoe", Description = "Used Chevy Tahoe SUV", Mileage = 40000, AverageRating = 4.2 }
                );
            modelBuilder.Entity<ShoppingCart>()
                .HasKey(c => new { c.UserId, c.CarId });
            
            

            modelBuilder.ApplyConfiguration(new RolesConfiguration());



        }

    }
}
