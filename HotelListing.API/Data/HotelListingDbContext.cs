using Microsoft.EntityFrameworkCore;

namespace HotelListing.API.Data
{
    public class HotelListingDbContext: DbContext
    {
        public HotelListingDbContext(DbContextOptions options): base(options)
        {
            
        }

        //Craeting tables via migrations
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasData(
                new Country
                {
                    Id = 1,
                    Name = "India",
                    ShortName = "IN",
                },
                new Country
                {
                    Id = 2,
                    Name = "Canada",
                    ShortName = "CA",
                },
                new Country
                {
                    Id = 3,
                    Name = "Europe",
                    ShortName = "EU",
                }
            );

            modelBuilder.Entity<Hotel>().HasData(
                new Hotel
                {
                    Id=1,
                    Name="Sandals Resort and Spa",
                    Address="Banglore",
                    CountryId = 1,
                    Rating=4
                },
                new Hotel
                {
                    Id = 2,
                    Name = "Rice and Noodles",
                    Address = "Vancouver",
                    CountryId = 2,
                    Rating = 4.5
                },
                new Hotel
                {
                    Id = 3,
                    Name = "Grand Palldium",
                    Address = "Paris",
                    CountryId = 3,
                    Rating = 4.3
                }
            );
        }
    }
}
