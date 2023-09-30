using Microsoft.EntityFrameworkCore;
using Villa.Models;

namespace Villa.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Villas> Villas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Villas>().HasData(
                      new Villas()
                      {
                          Id = 1,
                          Name = "Royal Villa",
                          Details = " larger than standard hotel rooms and may encompass multiple rooms, including bedrooms, living rooms, dining areas, and private gardens or terraces.",
                          ImageUrl = "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa3.jpg",
                          Occupancy = 5,
                          Rate = 200,
                          Sqft = 550,
                          Amenity = "",
                          CreatedDate = DateTime.Now
                      },
                      new Villas
                      {
                          Id = 2,
                          Name = "Premium Pool Villa",
                          Details = "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.",
                          ImageUrl = "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa1.jpg",
                          Occupancy = 4,
                          Rate = 300,
                          Sqft = 550,
                          Amenity = "",
                          CreatedDate = DateTime.Now
                      },
                      new Villas
                      {
                          Id = 3,
                          Name = "Luxury Pool Villa",
                          Details = "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.",
                          ImageUrl = "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa4.jpg",
                          Occupancy = 4,
                          Rate = 400,
                          Sqft = 750,
                          Amenity = "",
                          CreatedDate = DateTime.Now
                      },
                      new Villas
                      {
                          Id = 4,
                          Name = "Diamond Villa",
                          Details = "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.",
                          ImageUrl = "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa5.jpg",
                          Occupancy = 4,
                          Rate = 550,
                          Sqft = 900,
                          Amenity = "",
                          CreatedDate = DateTime.Now
                      },
                      new Villas
                      {
                          Id = 5,
                          Name = "Diamond Pool Villa",
                          Details = "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.",
                          ImageUrl = "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa2.jpg",
                          Occupancy = 4,
                          Rate = 600,
                          Sqft = 1100,
                          Amenity = "",
                          CreatedDate = DateTime.Now
                      }
                );
        }
    }
}