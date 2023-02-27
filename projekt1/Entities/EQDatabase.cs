using Microsoft.EntityFrameworkCore;
using System.Windows.Markup;

namespace projekt1.Entities
{
    internal class EQDatabase : DbContext
    {
        private string _connectionString = @"Data Source=LAPTOP-E0VUJMJ1\MSSQLSERVER2;Initial Catalog=SkiDB;User ID=sa;Password=test;Trusted_Connection=True;";
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Equipment> Equipment { get; set; }
        public DbSet<Renting> Renting { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .Property(c => c.Name)
                .IsRequired();
            modelBuilder.Entity<Customer>()
                .Property(c => c.Surname)
                .IsRequired();
            modelBuilder.Entity<Equipment>()
                .Property(b => b.Id)
                .IsRequired();
            modelBuilder.Entity<Equipment>()
                .Property(b => b.IsRented)
                .IsRequired();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }
    }
}
