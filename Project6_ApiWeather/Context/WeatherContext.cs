using Microsoft.EntityFrameworkCore;
using Project6_ApiWeather.Entities;

namespace Project6_ApiWeather.Context
{


    // Entity Framework Core ile bir veritabanı bağlamı (context) oluşturan bir sınıftır.
    // WeatherContext sınıfı, veritabanı işlemlerini yönetmek için kullanılır ve veritabanıyla etkileşime geçmek isteyen sınıfların bir yapı taşıdır. 
    public class WeatherContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server= Kaan\\SQLEXPRESS;initial catalog= Db6Project20; integrated Security=true; TrustServerCertificate=True");
        }
        public DbSet<City> Cities { get; set; }
    }
}
