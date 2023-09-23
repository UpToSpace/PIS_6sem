using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _4.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Data> Data { get; set; }

        public ApplicationContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-6BQAJ6M;Database=phones;User=lera;Password=Vv1542139;TrustServerCertificate=True");
        }
    }
}