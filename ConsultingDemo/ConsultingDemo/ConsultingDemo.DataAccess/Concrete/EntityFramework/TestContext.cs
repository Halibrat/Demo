using ConsultingDemo.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsultingDemo.DataAccess.Concrete.EntityFramework
{
  public class TestContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Test;Trusted_Connection=true");
        }
        public DbSet<STI> STIs { get; set; }
        public DbSet<STK> STKs { get; set; }
    }
    
}
