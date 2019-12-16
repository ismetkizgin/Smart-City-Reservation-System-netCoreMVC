﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TheEye.DataAccess.Concrete.EntityFramework;

namespace TheEye.DataAccess.Migrations
{
    [DbContext(typeof(TheEyeContext))]
    [Migration("20191216123912_TheEyeDB")]
    partial class TheEyeDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TheEye.Entities.Concrete.CarPark", b =>
                {
                    b.Property<int>("CarParkId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool?>("CarParkDisabled");

                    b.Property<byte?>("CarParkFloor");

                    b.Property<int?>("CarParkMax");

                    b.Property<string>("CarParkTire");

                    b.Property<string>("CarParkWashing");

                    b.Property<int?>("CompanyId");

                    b.HasKey("CarParkId");

                    b.HasIndex("CompanyId");

                    b.ToTable("CarParks");
                });

            modelBuilder.Entity("TheEye.Entities.Concrete.Company", b =>
                {
                    b.Property<int>("CompanyId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CompanyAdress");

                    b.Property<string>("CompanyCity");

                    b.Property<string>("CompanyDistrict");

                    b.Property<string>("CompanyMail");

                    b.Property<string>("CompanyName");

                    b.Property<string>("CompanyPhone");

                    b.Property<DateTime?>("CompanyTime");

                    b.Property<string>("CompanyType");

                    b.HasKey("CompanyId");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("TheEye.Entities.Concrete.Medicine", b =>
                {
                    b.Property<int>("MedicineId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CompanyId");

                    b.Property<string>("MedicineName");

                    b.Property<string>("MedicinePiece");

                    b.Property<string>("MedicinePrescription");

                    b.Property<string>("MedicineType");

                    b.HasKey("MedicineId");

                    b.HasIndex("CompanyId");

                    b.ToTable("Medicines");
                });

            modelBuilder.Entity("TheEye.Entities.Concrete.PetrolStation", b =>
                {
                    b.Property<int>("PetrolId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CompanyId");

                    b.Property<string>("PetrolFuelType");

                    b.Property<string>("PetrolMarkets");

                    b.Property<string>("PetrolTire");

                    b.Property<string>("PetrolWashing");

                    b.HasKey("PetrolId");

                    b.HasIndex("CompanyId");

                    b.ToTable("PetrolStations");
                });

            modelBuilder.Entity("TheEye.Entities.Concrete.Request", b =>
                {
                    b.Property<int>("RequestId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("MedicineId");

                    b.Property<bool?>("RequestActive");

                    b.Property<string>("RequestAmaunt");

                    b.Property<DateTime?>("RequestTime");

                    b.Property<int?>("UserId");

                    b.HasKey("RequestId");

                    b.HasIndex("MedicineId");

                    b.HasIndex("UserId");

                    b.ToTable("Requests");
                });

            modelBuilder.Entity("TheEye.Entities.Concrete.Reservation", b =>
                {
                    b.Property<int>("ReservationId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CarParkId");

                    b.Property<DateTime?>("ReservationTime");

                    b.Property<int?>("UserId");

                    b.HasKey("ReservationId");

                    b.HasIndex("CarParkId");

                    b.HasIndex("UserId");

                    b.ToTable("Reservations");
                });

            modelBuilder.Entity("TheEye.Entities.Concrete.Ssn", b =>
                {
                    b.Property<int>("SsnId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CompanyId");

                    b.Property<int>("UserId");

                    b.HasKey("SsnId");

                    b.HasIndex("CompanyId");

                    b.HasIndex("UserId");

                    b.ToTable("Ssn");
                });

            modelBuilder.Entity("TheEye.Entities.Concrete.Sss", b =>
                {
                    b.Property<int>("SssId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("SsnId");

                    b.Property<string>("SssQuestion");

                    b.Property<string>("SssReply");

                    b.HasKey("SssId");

                    b.HasIndex("SsnId");

                    b.ToTable("Sss");
                });

            modelBuilder.Entity("TheEye.Entities.Concrete.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("UserAdress");

                    b.Property<string>("UserCity");

                    b.Property<string>("UserDistrict");

                    b.Property<bool?>("UserGender");

                    b.Property<string>("UserMail");

                    b.Property<string>("UserName");

                    b.Property<string>("UserPassword");

                    b.Property<string>("UserPhone");

                    b.Property<int?>("UserType");

                    b.Property<DateTime?>("UserYears");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("TheEye.Entities.Concrete.CarPark", b =>
                {
                    b.HasOne("TheEye.Entities.Concrete.Company", "Company")
                        .WithMany("CarParks")
                        .HasForeignKey("CompanyId");
                });

            modelBuilder.Entity("TheEye.Entities.Concrete.Medicine", b =>
                {
                    b.HasOne("TheEye.Entities.Concrete.Company", "Company")
                        .WithMany("Medicines")
                        .HasForeignKey("CompanyId");
                });

            modelBuilder.Entity("TheEye.Entities.Concrete.PetrolStation", b =>
                {
                    b.HasOne("TheEye.Entities.Concrete.Company", "Company")
                        .WithMany("PetrolStations")
                        .HasForeignKey("CompanyId");
                });

            modelBuilder.Entity("TheEye.Entities.Concrete.Request", b =>
                {
                    b.HasOne("TheEye.Entities.Concrete.Medicine", "Medicine")
                        .WithMany("Requests")
                        .HasForeignKey("MedicineId");

                    b.HasOne("TheEye.Entities.Concrete.User", "User")
                        .WithMany("Requests")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("TheEye.Entities.Concrete.Reservation", b =>
                {
                    b.HasOne("TheEye.Entities.Concrete.CarPark", "CarPark")
                        .WithMany("Reservations")
                        .HasForeignKey("CarParkId");

                    b.HasOne("TheEye.Entities.Concrete.User", "User")
                        .WithMany("Reservations")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("TheEye.Entities.Concrete.Ssn", b =>
                {
                    b.HasOne("TheEye.Entities.Concrete.Company", "Company")
                        .WithMany("Ssn")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TheEye.Entities.Concrete.User", "User")
                        .WithMany("Ssn")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TheEye.Entities.Concrete.Sss", b =>
                {
                    b.HasOne("TheEye.Entities.Concrete.Ssn", "Ssn")
                        .WithMany("Sss")
                        .HasForeignKey("SsnId");
                });
#pragma warning restore 612, 618
        }
    }
}
