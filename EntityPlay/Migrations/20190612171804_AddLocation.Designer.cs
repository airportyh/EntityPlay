﻿// <auto-generated />
using System;
using EntityPlay.Databases;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EntityPlay.Migrations
{
    [DbContext(typeof(ExampleDatabase))]
    [Migration("20190612171804_AddLocation")]
    partial class AddLocation
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EntityPlay.Entities.Appointment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CustomerId");

                    b.Property<DateTimeOffset>("Date");

                    b.Property<string>("Location");

                    b.Property<string>("Notes");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Appointments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CustomerId = 1,
                            Date = new DateTimeOffset(new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -5, 0, 0, 0)),
                            Title = "Get Teeth Cleaned"
                        },
                        new
                        {
                            Id = 2,
                            CustomerId = 2,
                            Date = new DateTimeOffset(new DateTime(2019, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -5, 0, 0, 0)),
                            Title = "Get Teeth Pulled"
                        },
                        new
                        {
                            Id = 3,
                            CustomerId = 2,
                            Date = new DateTimeOffset(new DateTime(2019, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -4, 0, 0, 0)),
                            Title = "Get hair cut"
                        },
                        new
                        {
                            Id = 4,
                            CustomerId = 2,
                            Date = new DateTimeOffset(new DateTime(2019, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -4, 0, 0, 0)),
                            Title = "Get coffee"
                        },
                        new
                        {
                            Id = 5,
                            CustomerId = 1,
                            Date = new DateTimeOffset(new DateTime(2019, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -4, 0, 0, 0)),
                            Title = "Get tea"
                        });
                });

            modelBuilder.Entity("EntityPlay.Entities.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 5,
                            Name = "James"
                        },
                        new
                        {
                            Id = 2,
                            Age = 6,
                            Name = "Byron"
                        },
                        new
                        {
                            Id = 3,
                            Age = 7,
                            Name = "Nora"
                        });
                });

            modelBuilder.Entity("EntityPlay.Entities.Appointment", b =>
                {
                    b.HasOne("EntityPlay.Entities.Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}
