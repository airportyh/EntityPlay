﻿using EntityPlay.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityPlay.Databases
{
    public class ExampleDatabase : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Appointment> Appointments { get; set; }

        public ExampleDatabase(DbContextOptions<ExampleDatabase> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Appointment>(appointment =>
            {
                appointment
                    .HasOne<Customer>()
                    .WithMany()
                    .HasForeignKey(fk => fk.CustomerId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<Customer>().HasData(
                new Customer() { Id = 1, Age = 5, Name = "James", Email = "James@gmail.com" },
                new Customer() { Id = 2, Age = 6, Name = "Byron", Email = "byron@hotmail.com" },
                new Customer() { Id = 3, Age = 7, Name = "Nora", Email = "nora@aol.com" },
                new Customer() { Id = 4, Age = 4, Name = "Cameron", Email = "cameron@gmail.com" }
            );

            modelBuilder.Entity<Appointment>().HasData(
                new Appointment() { Id = 1, CustomerId = 1, Date = new DateTime(2019, 1, 1), AppointmentName = "Get Teeth Cleaned", Notes = "They are dirty" },
                new Appointment() { Id = 2, CustomerId = 2, Date = new DateTime(2019, 2, 5), AppointmentName = "Get Teeth Pulled", Notes = "They hurt" },
                new Appointment() { Id = 3, CustomerId = 2, Date = new DateTime(2019, 5, 1), AppointmentName = "Get hair cut", Notes = "Too long" },
                new Appointment() { Id = 4, CustomerId = 2, Date = new DateTime(2019, 6, 1), AppointmentName = "Get coffee", Notes = "I am sleepy" },
                new Appointment() { Id = 5, CustomerId = 1, Date = new DateTime(2019, 7, 4), AppointmentName = "Get tea", Notes = "My tummy hurts" }
            );
        }
    }
}
