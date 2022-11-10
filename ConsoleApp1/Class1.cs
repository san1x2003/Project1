using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Text;
using System.IO;


namespace Practice1
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Zakaz> Zakaz { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory());
            builder.AddJsonFile("apppconfig.json");
            var config = builder.Build();
            string connectionString = config.GetConnectionString("DefaultConnection");

            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}