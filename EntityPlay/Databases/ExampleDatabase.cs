using EntityPlay.Entities;
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
                new Customer() { Id = 1, Age = 5, Name = "James" },
                new Customer() { Id = 2, Age = 6, Name = "Byron" },
                new Customer() { Id = 3, Age = 7, Name = "Nora" }
            );

            modelBuilder.Entity<Appointment>().HasData(
                new Appointment() { Id = 1, CustomerId = 1, Date = DateTime.Now, Title = "Get Teeth Cleaned" },
                new Appointment() { Id = 2, CustomerId = 2, Date = DateTime.Now, Title = "Get Teeth Pulled" }
            );
        }
    }
}
