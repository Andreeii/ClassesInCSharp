using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesInCSharp
{
    public partial class CarContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("Data Source=DESKTOP-B0LQIU9;Initial Catalog=CarDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        }

        public DbSet<Engine> Engines { get; set; }

        public DbSet<BenzineEngine> Benzins { get; set; }
        public DbSet<DieselEngine> Diesels { get; set; }

        public DbSet<LuxuryCar>LuxuryCars{get;set;}

        public DbSet<SportCar> SportCars { get; set; }

        public DbSet<ArmyCar> ArmyCars { get; set; }
        public DbSet<Car> Cars{get;set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
