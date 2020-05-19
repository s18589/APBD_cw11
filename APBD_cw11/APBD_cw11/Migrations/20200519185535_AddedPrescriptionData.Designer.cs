﻿// <auto-generated />
using System;
using APBD_cw11.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace APBD_cw11.Migrations
{
    [DbContext(typeof(ClinicDbContext))]
    [Migration("20200519185535_AddedPrescriptionData")]
    partial class AddedPrescriptionData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("APBD_cw11.Models.Doctor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Doctors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "AAA@email.com",
                            FirstName = "AAA",
                            LastName = "AAA"
                        },
                        new
                        {
                            Id = 2,
                            Email = "BBB@email.com",
                            FirstName = "BBB",
                            LastName = "BBB"
                        });
                });

            modelBuilder.Entity("APBD_cw11.Models.Medicament", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Medicaments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "fajny",
                            Name = "acodin",
                            Type = "potezny"
                        },
                        new
                        {
                            Id = 2,
                            Description = "na przeziebienie",
                            Name = "rutinoscorbin",
                            Type = "bez recepty"
                        });
                });

            modelBuilder.Entity("APBD_cw11.Models.Patient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Patients");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BirthDate = new DateTime(2020, 5, 19, 20, 55, 35, 171, DateTimeKind.Local).AddTicks(2114),
                            FirstName = "AAA",
                            LastName = "BBB"
                        });
                });

            modelBuilder.Entity("APBD_cw11.Models.Prescription", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DueDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdDoctor")
                        .HasColumnType("int");

                    b.Property<int>("IdPatient")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdDoctor");

                    b.HasIndex("IdPatient");

                    b.ToTable("Prescriptions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Date = new DateTime(2020, 5, 19, 20, 55, 35, 173, DateTimeKind.Local).AddTicks(9146),
                            DueDate = new DateTime(2020, 5, 19, 20, 55, 35, 173, DateTimeKind.Local).AddTicks(9629),
                            IdDoctor = 1,
                            IdPatient = 1
                        },
                        new
                        {
                            Id = 2,
                            Date = new DateTime(2020, 5, 19, 20, 55, 35, 174, DateTimeKind.Local).AddTicks(824),
                            DueDate = new DateTime(2020, 5, 19, 20, 55, 35, 174, DateTimeKind.Local).AddTicks(850),
                            IdDoctor = 2,
                            IdPatient = 1
                        });
                });

            modelBuilder.Entity("APBD_cw11.Models.PrescrtiptionMedicament", b =>
                {
                    b.Property<int>("IdPrescription")
                        .HasColumnType("int");

                    b.Property<int>("IdMedicament")
                        .HasColumnType("int");

                    b.Property<string>("Details")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<int>("Dose")
                        .HasColumnType("int");

                    b.HasKey("IdPrescription", "IdMedicament");

                    b.HasIndex("IdMedicament");

                    b.ToTable("PrescrtiptionMedicaments");
                });

            modelBuilder.Entity("APBD_cw11.Models.Prescription", b =>
                {
                    b.HasOne("APBD_cw11.Models.Doctor", "Doctor")
                        .WithMany()
                        .HasForeignKey("IdDoctor")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("APBD_cw11.Models.Patient", "Patient")
                        .WithMany()
                        .HasForeignKey("IdPatient")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("APBD_cw11.Models.PrescrtiptionMedicament", b =>
                {
                    b.HasOne("APBD_cw11.Models.Medicament", "Medicament")
                        .WithMany("PrescrtiptionMedicament")
                        .HasForeignKey("IdMedicament")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("APBD_cw11.Models.Prescription", "Prescription")
                        .WithMany("PrescrtiptionMedicament")
                        .HasForeignKey("IdPrescription")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
