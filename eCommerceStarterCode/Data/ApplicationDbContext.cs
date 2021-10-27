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
                    new Car { Id = 1, Price = 20000, Make = "Hyundai", Model = "Elantra", Year = 2022, Type = "Sedan",  Description = "Entry level compact sedan.", Mileage = 0, AverageRating = 0 },
                    new Car { Id = 2, Price = 26000, Make = "Toyota", Model = "Camry", Year = 2022, Type = "Sedan", Description = "Entry level mid-size sedan.", Mileage = 0, AverageRating = 0 },
                    new Car { Id = 3, Price = 40000, Make = "Lexus", Model = "ES", Year = 2022, Type = "Sedan", Description = "Entry level mid-size luxury sedan.", Mileage = 0, AverageRating = 0 },
                    new Car { Id = 4, Price = 27000, Make = "Toyota", Model = "RAV4", Year = 2022, Type = "SUV", Description = "Entry level compact SUV.", Mileage = 0, AverageRating = 0 },
                    new Car { Id = 5, Price = 30000, Make = "Kia", Model = "Sorento", Year = 2022, Type = "SUV", Description = "Entry level mid-size SUV.", Mileage = 0, AverageRating = 0 },
                    new Car { Id = 6, Price = 50000, Make = "Ford", Model = "Expedition", Year = 2022, Type = "SUV", Description = "Entry level large SUV.", Mileage = 0, AverageRating = 0 },
                    new Car { Id = 7, Price = 35000, Make = "Toyota", Model = "Sienna", Year = 2022, Type = "Minivan", Description = "Entry level Minivan.", Mileage = 0, AverageRating = 0 },
                    new Car { Id = 8, Price = 33000, Make = "Honda", Model = "Odyssey", Year = 2022, Type = "Minivan", Description = "Entry level Minivan.", Mileage = 0, AverageRating = 0 },
                    new Car { Id = 9, Price = 35000, Make = "Chrysler", Model = "Pacifica", Year = 2022, Type = "Minivan", Description = "Entry level Minivan.", Mileage = 0, AverageRating = 0 },
                    new Car { Id = 10, Price = 35000, Make = "Toyota", Model = "Sienna", Year = 2022, Type = "Minivan", Description = "Entry level Minivan.", Mileage = 0, AverageRating = 0 },
                    new Car { Id = 11, Price = 38000, Make = "Ford", Model = "F-150", Year = 2022, Type = "Truck", Description = "Entry level pickup truck.", Mileage = 0, AverageRating = 0 },
                    new Car { Id = 12, Price = 36000, Make = "Ram", Model = "1500", Year = 2022, Type = "Truck", Description = "Entry level pickup truck.", Mileage = 0, AverageRating = 0 },
                    new Car { Id = 13, Price = 36000, Make = "Chevrolet", Model = "Silverado 1500", Year = 2022, Type = "Truck", Description = "Entry level pickup truck.", Mileage = 0, AverageRating = 0 }
                );
            modelBuilder.Entity<ShoppingCart>()
                .HasKey(c => new { c.UserId, c.CarId });
            
            

            modelBuilder.ApplyConfiguration(new RolesConfiguration());
        }

    }
}
