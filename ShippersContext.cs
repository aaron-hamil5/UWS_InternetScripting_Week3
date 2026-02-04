using System.Dynamic;
using Microsoft.EntityFrameworkCore;

namespace ShippersContext
{
    public class ShippersDatabase : DbContext
    {
        public DbSet<Shipper> Shippers {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=Northwind.db");
        }
    }
}