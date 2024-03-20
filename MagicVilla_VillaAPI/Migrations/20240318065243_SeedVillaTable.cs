using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MagicVilla_VillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeedVillaTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "Amenity", "CreatedDate", "Details", "ImageUrl", "Name", "Occupancy", "Rate", "Sqft", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "Private beach, swimming pool, jacuzzi", new DateTime(2023, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Luxury villa with stunning ocean views, private beach access, and modern amenities.", "https://example.com/ocean_villa.jpg", "Ocean Paradise Villa", 8, 300.0, 4000, new DateTime(2023, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "Scenic views, hiking trails, fireplace", new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Secluded villa nestled in the mountains, perfect for a peaceful getaway.", "https://example.com/mountain_villa.jpg", "Mountain Retreat Villa", 6, 250.0, 3500, new DateTime(2023, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "Lake access, fishing pier, BBQ area", new DateTime(2023, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Charming villa overlooking a serene lake, ideal for relaxation and water activities.", "https://example.com/lakeside_villa.jpg", "Lakeside Haven Villa", 7, 280.0, 3800, new DateTime(2023, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "Infinity pool, spa, private dock", new DateTime(2023, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Exquisite villa on the shores of a tranquil lake, offering unparalleled luxury and relaxation.", "https://example.com/luxury_lakeside_villa.jpg", "Luxury Lakeside Retreat", 10, 500.0, 6000, new DateTime(2023, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, "Garden, fireplace, outdoor dining area", new DateTime(2023, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quaint cottage nestled in the countryside, perfect for a romantic retreat.", "https://example.com/countryside_cottage.jpg", "Cozy Countryside Cottage", 4, 150.0, 2000, new DateTime(2023, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, "Pool with waterfall, sand dunes exploration, stargazing deck", new DateTime(2023, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Spectacular villa oasis in the heart of the desert, offering luxury and adventure.", "https://example.com/desert_oasis_villa.jpg", "Desert Oasis Villa", 8, 400.0, 4500, new DateTime(2023, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, "Swimming pool with waterfall, outdoor bar, hammock garden", new DateTime(2023, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Exotic villa surrounded by lush tropical gardens, offering a true paradise experience.", "https://example.com/tropical_paradise_villa.jpg", "Tropical Paradise Villa", 6, 350.0, 5000, new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 7);
        }
    }
}
