using Microsoft.EntityFrameworkCore;
using NailPressApi.Models;


namespace NailPressApi.Data
{
    public class NailPressDb : DbContext
    {
        public NailPressDb(DbContextOptions<NailPressDb> options)
            : base(options) { }

        public DbSet<Listing> Listings => Set<Listing>();
        public DbSet<Customer> Customers => Set<Customer>();

        // Configure relationships and constraints here if needed and can't go in entity classes.
        // protected override void OnModelCreating(ModelBuilder modelBuilder)
        // {

        // }

    }
}