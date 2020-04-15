using System.Collections.Generic;
using System.Data;
using ColdChain.Entity;
using ColdChain.Entity.BaseInfo;
using ColdChain.Mapping.BaseInfo;
using Microsoft.EntityFrameworkCore;

namespace ColdChain.EntityFramework
{
    public class ColdChainDbContext : DbContext
    {
        public DbSet<AreaEntity> Area { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Data Source=blogging.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AreaMapping());
        }
    }
}