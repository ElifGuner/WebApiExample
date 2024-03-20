using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using System.Reflection.Metadata;

namespace WebApiExample.Model
{
    public class HotelDBContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("server=bss01; Database=CTestDB;uid=sa;pwd=q1w2e3r4t5*X;TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder); 
            modelBuilder.Entity<Hotel>()
            .HasData(
                new Hotel() { Id = 3, Name = "Cactus", City = "Bodrum" },
                new Hotel() { Id = 4, Name = "Club Aqua Plaza", City = "Antalya" }
                );
        }

        public DbSet<Hotel> Hotels { get; set; }
    }
}
