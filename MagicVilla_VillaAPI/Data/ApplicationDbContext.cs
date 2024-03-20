using MagicVilla_VillaAPI.Models;
using Microsoft.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MagicVilla_VillaAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
            : base(options)
        {

        }

        public DbSet<LocalUser> LocalUsers { get; set; }
        public DbSet<Villa> Villas { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Villa>().HasData(
                new Villa
                {
                    Id = 1,
                    Name = "Ocean Paradise Villa",
                    Details = "Luxury villa with stunning ocean views, private beach access, and modern amenities.",
                    Rate = 300,
                    Sqft = 4000,
                    Occupancy = 8,
                    ImageUrl = "https://example.com/ocean_villa.jpg",
                    Amenity = "Private beach, swimming pool, jacuzzi",
                    CreatedDate = new DateTime(2023, 01, 15),
                    UpdatedDate = new DateTime(2023, 05, 20)
                },
                new Villa
                {
                    Id = 2,
                    Name = "Mountain Retreat Villa",
                    Details = "Secluded villa nestled in the mountains, perfect for a peaceful getaway.",
                    Rate = 250,
                    Sqft = 3500,
                    Occupancy = 6,
                    ImageUrl = "https://example.com/mountain_villa.jpg",
                    Amenity = "Scenic views, hiking trails, fireplace",
                    CreatedDate = new DateTime(2023, 03, 10),
                    UpdatedDate = new DateTime(2023, 09, 18)
                },
                new Villa
                {
                    Id = 3,
                    Name = "Lakeside Haven Villa",
                    Details = "Charming villa overlooking a serene lake, ideal for relaxation and water activities.",
                    Rate = 280,
                    Sqft = 3800,
                    Occupancy = 7,
                    ImageUrl = "https://example.com/lakeside_villa.jpg",
                    Amenity = "Lake access, fishing pier, BBQ area",
                    CreatedDate = new DateTime(2023, 06, 05),
                    UpdatedDate = new DateTime(2023, 12, 12)
                },
                new Villa
                {
                    Id = 4,
                    Name = "Luxury Lakeside Retreat",
                    Details = "Exquisite villa on the shores of a tranquil lake, offering unparalleled luxury and relaxation.",
                    Rate = 500,
                    Sqft = 6000,
                    Occupancy = 10,
                    ImageUrl = "https://example.com/luxury_lakeside_villa.jpg",
                    Amenity = "Infinity pool, spa, private dock",
                    CreatedDate = new DateTime(2023, 02, 28),
                    UpdatedDate = new DateTime(2023, 10, 05)
                },
                new Villa
                {
                    Id = 5,
                    Name = "Cozy Countryside Cottage",
                    Details = "Quaint cottage nestled in the countryside, perfect for a romantic retreat.",
                    Rate = 150,
                    Sqft = 2000,
                    Occupancy = 4,
                    ImageUrl = "https://example.com/countryside_cottage.jpg",
                    Amenity = "Garden, fireplace, outdoor dining area",
                    CreatedDate = new DateTime(2023, 04, 12),
                    UpdatedDate = new DateTime(2023, 11, 20)
                },
                new Villa
                {
                    Id = 6,
                    Name = "Desert Oasis Villa",
                    Details = "Spectacular villa oasis in the heart of the desert, offering luxury and adventure.",
                    Rate = 400,
                    Sqft = 4500,
                    Occupancy = 8,
                    ImageUrl = "https://example.com/desert_oasis_villa.jpg",
                    Amenity = "Pool with waterfall, sand dunes exploration, stargazing deck",
                    CreatedDate = new DateTime(2023, 07, 20),
                    UpdatedDate = new DateTime(2023, 12, 30)
                },
                new Villa
                {
                    Id = 7,
                    Name = "Tropical Paradise Villa",
                    Details = "Exotic villa surrounded by lush tropical gardens, offering a true paradise experience.",
                    Rate = 350,
                    Sqft = 5000,
                    Occupancy = 6,
                    ImageUrl = "https://example.com/tropical_paradise_villa.jpg",
                    Amenity = "Swimming pool with waterfall, outdoor bar, hammock garden",
                    CreatedDate = new DateTime(2023, 09, 15),
                    UpdatedDate = new DateTime(2024, 01, 25)
                });

        }
    }
}
