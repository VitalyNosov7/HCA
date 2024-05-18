using Microsoft.EntityFrameworkCore;

namespace HotelCalcApp.Model.Data
{
    public class HotelCalcAppDBContext : DbContext
    {
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<HotelService> HotelServices { get; set; }
        public DbSet<HotelServicePrice> HotelServicePrices { get; set; }
        public DbSet<ServiceSaleStop> ServiceSaleStops { get; set; }

        public String DbPath { get; } = "hotelCalcAppDb.db";

        public HotelCalcAppDBContext()
        {
           // Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data Source={DbPath}");
        }
    }
}
