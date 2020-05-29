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
        public DbSet<Card> Cards { get; set; }

        public DbSet<Estimate> Estimates { get; set; }


        public EstimateDbContext(DbContextOptions<EstimateDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Card>().ToTable("Card");
            modelBuilder.Entity<Estimate>().ToTable("Estimates");
        }
    }
}
