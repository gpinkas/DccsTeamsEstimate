using DccsTeamsEstimate.DataAccess.DataModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DccsTeamsEstimate.DataAccess
{
    public class EstimateDbContext : DbContext
    {
        private const string _instanceName = "Test";

        public DbSet<Card> Cards { get; set; }

        public DbSet<Estimate> Estimates { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var filename = $"db_{_instanceName}.sqlite";

            optionsBuilder
                .UseSqlite(@$"Data Source={filename};");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Card>().ToTable("Card");
            modelBuilder.Entity<Estimate>().ToTable("Estimates");
        }
    }
}
