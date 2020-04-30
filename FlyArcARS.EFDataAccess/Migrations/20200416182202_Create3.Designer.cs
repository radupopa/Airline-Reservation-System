﻿// <auto-generated />
using System;
using FlyArcARS.EFDataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FlyArcARS.EFDataAccess.Migrations
{
    [DbContext(typeof(FlyArcDbContext))]
    [Migration("20200416182202_Create3")]
    partial class Create3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FlyArcARS.ApplicationLogic.Data.Administrator", b =>
                {
                    b.Property<Guid>("AdministratorId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FullName");

                    b.Property<string>("Password");

                    b.Property<string>("UserName");

                    b.HasKey("AdministratorId");

                    b.ToTable("Administrator");
                });

            modelBuilder.Entity("FlyArcARS.ApplicationLogic.Data.Customer", b =>
                {
                    b.Property<Guid>("CustomerId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Password");

                    b.Property<string>("UserName");

                    b.HasKey("CustomerId");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("FlyArcARS.ApplicationLogic.Data.Flight", b =>
                {
                    b.Property<Guid>("FlightId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Destination");

                    b.Property<string>("Name");

                    b.Property<int>("NumberOfSeats");

                    b.Property<string>("Source");

                    b.Property<int>("Time");

                    b.HasKey("FlightId");

                    b.ToTable("Flight");
                });

            modelBuilder.Entity("FlyArcARS.ApplicationLogic.Data.Passenger", b =>
                {
                    b.Property<Guid>("PassengerId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<Guid?>("AdministratorId");

                    b.Property<int>("Age");

                    b.Property<string>("City");

                    b.Property<string>("Country");

                    b.Property<Guid?>("CustomerId");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("Mail");

                    b.HasKey("PassengerId");

                    b.HasIndex("AdministratorId");

                    b.HasIndex("CustomerId");

                    b.ToTable("Passenger");
                });

            modelBuilder.Entity("FlyArcARS.ApplicationLogic.Data.Ticket", b =>
                {
                    b.Property<Guid>("TicketId")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("FlightId");

                    b.Property<string>("PassengerFirstName");

                    b.Property<Guid?>("PassengerId");

                    b.Property<string>("PassengerLastName");

                    b.Property<double>("Price");

                    b.Property<string>("Type");

                    b.HasKey("TicketId");

                    b.HasIndex("FlightId");

                    b.HasIndex("PassengerId");

                    b.ToTable("Ticket");
                });

            modelBuilder.Entity("FlyArcARS.ApplicationLogic.Data.Passenger", b =>
                {
                    b.HasOne("FlyArcARS.ApplicationLogic.Data.Administrator")
                        .WithMany("Customers")
                        .HasForeignKey("AdministratorId");

                    b.HasOne("FlyArcARS.ApplicationLogic.Data.Customer")
                        .WithMany("Passengers")
                        .HasForeignKey("CustomerId");
                });

            modelBuilder.Entity("FlyArcARS.ApplicationLogic.Data.Ticket", b =>
                {
                    b.HasOne("FlyArcARS.ApplicationLogic.Data.Flight")
                        .WithMany("Tickets")
                        .HasForeignKey("FlightId");

                    b.HasOne("FlyArcARS.ApplicationLogic.Data.Passenger")
                        .WithMany("Tickets")
                        .HasForeignKey("PassengerId");
                });
#pragma warning restore 612, 618
        }
    }
}
