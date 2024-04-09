using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata.Ecma335;

namespace Razor.Net_Core.Models
{
    public class MyDbContext : DbContext
    {
        public DbSet<Person> People { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("MyDb");
        }
    }
}
