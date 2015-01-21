using EF7GetStarted.Models;
using Microsoft.Data.Entity;

namespace EF7GetStarted
{
    public class PersonContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }

        protected override void OnConfiguring(DbContextOptions options)
        {
            base.OnConfiguring(options);
        }
    }
}