using hww;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace hww
{
    public class CountryContext: DbContext
    {
        public DbSet<CountryModel> Countries { get; set; }
        public DbSet<Continent> Continents { get; set; }


        public CountryContext() {

            if (Database.EnsureCreated())
            {

    
                Continent continent = new Continent("Europe");
                CountryModel country = new CountryModel { Country = "Russia", Capital = "Moscow", Population = 146028325, Square = 17100000, Continent = continent };
                Continents?.Add(continent);
                Countries?.Add(country);
            }
        
        }


       

    }
}
