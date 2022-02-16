﻿// <auto-generated />
using MVCEmptyProject.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MVCEmptyProject.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220216095224_Added some seeded data")]
    partial class Addedsomeseededdata
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MVCEmptyProject.Models.Car", b =>
                {
                    b.Property<string>("RegNumber")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CarModel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RegNumber");

                    b.ToTable("Cars");

                    b.HasData(
                        new
                        {
                            RegNumber = "ABC-123",
                            Brand = "Volvo",
                            CarModel = "V70"
                        },
                        new
                        {
                            RegNumber = "DEF-456",
                            Brand = "SAAB",
                            CarModel = "93"
                        },
                        new
                        {
                            RegNumber = "GHI-789",
                            Brand = "BMW",
                            CarModel = "E39"
                        });
                });

            modelBuilder.Entity("MVCEmptyProject.Models.CarOwner", b =>
                {
                    b.Property<string>("CarRegNumber")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("OwnerId")
                        .HasColumnType("int");

                    b.HasKey("CarRegNumber", "OwnerId");

                    b.HasIndex("OwnerId");

                    b.ToTable("CarOwners");

                    b.HasData(
                        new
                        {
                            CarRegNumber = "ABC-123",
                            OwnerId = 1
                        },
                        new
                        {
                            CarRegNumber = "ABC-123",
                            OwnerId = 3
                        },
                        new
                        {
                            CarRegNumber = "GHI-789",
                            OwnerId = 1
                        },
                        new
                        {
                            CarRegNumber = "DEF-456",
                            OwnerId = 2
                        });
                });

            modelBuilder.Entity("MVCEmptyProject.Models.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("People");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 34,
                            City = "Stenstorp",
                            FirstName = "Jonathan",
                            LastName = "Krall"
                        },
                        new
                        {
                            Id = 2,
                            Age = 58,
                            City = "Anderstorp",
                            FirstName = "Anders",
                            LastName = "Andersson"
                        },
                        new
                        {
                            Id = 3,
                            Age = 37,
                            City = "Kimstorp",
                            FirstName = "Kim",
                            LastName = "Kimsson"
                        });
                });

            modelBuilder.Entity("MVCEmptyProject.Models.CarOwner", b =>
                {
                    b.HasOne("MVCEmptyProject.Models.Car", "Car")
                        .WithMany("CarOwners")
                        .HasForeignKey("CarRegNumber")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MVCEmptyProject.Models.Person", "Person")
                        .WithMany("CarOwners")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
