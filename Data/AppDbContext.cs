using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace azure_app_achref.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {

        }
        public DbSet<Person> Persons { get; set; }
    }
}
