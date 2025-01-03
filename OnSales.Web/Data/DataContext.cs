using Microsoft.EntityFrameworkCore;
using OnSales.Web.Data.Entities;

namespace OnSales.Web.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Country> Countries { get; set; }
        public DbSet<TaxesType> TaxeTypes { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Taxes> Taxes { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<State> Statements { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasIndex(c => c.NameCountry).IsUnique();

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<TaxesType>().HasIndex(c => c.NameTaxesType).IsUnique();

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasIndex(category => category.NameCategory).IsUnique();
            modelBuilder.Entity<State>().HasIndex(s => s.Name).IsUnique();
            modelBuilder.Entity<City>().HasIndex(c => c.Name).IsUnique();
         
            modelBuilder.Entity<TaxesType>().HasIndex(tp => tp.NameTaxesType).IsUnique();
            modelBuilder.Entity<State>().HasIndex("Name", "CountryId").IsUnique();


        }

    }
}
