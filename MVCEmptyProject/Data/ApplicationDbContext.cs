﻿using Microsoft.EntityFrameworkCore;
using MVCEmptyProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCEmptyProject.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Person> People { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<CarOwner> CarOwners { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CarOwner>().HasKey(co => new { co.CarRegNumber, co.OwnerId });

            modelBuilder.Entity<CarOwner>()
                .HasOne(co => co.Person)
                .WithMany(o => o.CarOwners)
                .HasForeignKey(co => co.OwnerId);

            modelBuilder.Entity<CarOwner>()
                .HasOne(co => co.Car)
                .WithMany(c => c.CarOwners)
                .HasForeignKey(co => co.CarRegNumber);


            modelBuilder.Entity<Person>().HasData(new Person { Id = 1, FirstName = "Jonathan", LastName = "Krall", Age = 34, City = "Stenstorp" });
            modelBuilder.Entity<Person>().HasData(new Person { Id = 2, FirstName = "Anders", LastName = "Andersson", Age = 58, City = "Anderstorp" });
            modelBuilder.Entity<Person>().HasData(new Person { Id = 3, FirstName = "Kim", LastName = "Kimsson", Age = 37, City = "Kimstorp" });

            modelBuilder.Entity<Car>().HasData(new Car { RegNumber = "ABC-123", Brand = "Volvo", CarModel = "V70" });
            modelBuilder.Entity<Car>().HasData(new Car { RegNumber = "DEF-456", Brand = "SAAB", CarModel = "93" });
            modelBuilder.Entity<Car>().HasData(new Car { RegNumber = "GHI-789", Brand = "BMW", CarModel = "E39" });

            modelBuilder.Entity<CarOwner>().HasData(new CarOwner { CarRegNumber = "ABC-123", OwnerId = 1 });
            modelBuilder.Entity<CarOwner>().HasData(new CarOwner { CarRegNumber = "ABC-123", OwnerId = 3 });
            modelBuilder.Entity<CarOwner>().HasData(new CarOwner { CarRegNumber = "GHI-789", OwnerId = 1 });
            modelBuilder.Entity<CarOwner>().HasData(new CarOwner { CarRegNumber = "DEF-456", OwnerId = 2 });

        }
    }    
}