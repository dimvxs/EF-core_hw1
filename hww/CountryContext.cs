using hww;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using Microsoft.EntityFrameworkCore.SqlServer;


namespace hww
{
    public class CountryContext: DbContext
    {
        public DbSet<CountryModel> Countries { get; set; }
        public DbSet<Continent> Continents { get; set; }

        static DbContextOptions<CountryContext> _options;


        static CountryContext() {

            var builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory());
            builder.AddJsonFile("appsettings.json");
            var config = builder.Build();
            string connection = config.GetConnectionString("DefaultConnection");
            var optionsBuilder = new DbContextOptionsBuilder<CountryContext>();
            _options = optionsBuilder.UseSqlServer(connection).Options;

           


            //if (Database.EnsureCreated())
            //{

    
            //    Continent continent = new Continent("Europe");
            //    CountryModel country = new CountryModel { Country = "Russia", Capital = "Moscow", Population = 146028325, Square = 17100000, Continent = continent };
            //    Continents?.Add(continent);
            //    Countries?.Add(country);
            //}
        
        }
        public CountryContext(): base(_options)
        {
            Database.EnsureCreated();
        }
        




    }
}
