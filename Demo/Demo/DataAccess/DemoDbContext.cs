using Demo.DataAccess.Interfaces;
using Demo.DataModels;
using Demo.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.DataAccess
{
    public class DemoDbContext : DbContext
    {
        public DbSet<CityDataModel> CityMaster { get; set; }

        public DemoDbContext(DbContextOptions<DemoDbContext> options) : base (options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CityDataModel>(entity =>
            {
                entity.ToTable("CityMaster");
            });

        }
    }
}
