using Microsoft.EntityFrameworkCore;






namespace Library
{
    public class Context: DbContext
    {
        public DbSet<CountryModel> countries { get; set; }

    }
}
