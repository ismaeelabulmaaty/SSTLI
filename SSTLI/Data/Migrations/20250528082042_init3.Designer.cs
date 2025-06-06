﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SSTLI.Data;

#nullable disable

namespace SSTLI.Data.Migrations
{
    [DbContext(typeof(SstliDbContext))]
    [Migration("20250528082042_init3")]
    partial class init3
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SSTLI.Models.RegistrationAttendanceOrOnline", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AttachEducationalQualificationImage")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(MAX)");

                    b.Property<int>("AttendanceType")
                        .HasColumnType("int");

                    b.Property<DateTime>("Batch")
                        .HasColumnType("datetime2");

                    b.Property<string>("Branch")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EducationalQualification")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NationalIdNumber")
                        .HasColumnType("int");

                    b.Property<int>("PhoneNumber")
                        .HasColumnType("int");

                    b.Property<int>("QualificationType")
                        .HasColumnType("int");

                    b.Property<string>("Signature")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(MAX)");

                    b.Property<string>("attachNationalIdImage")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(MAX)");

                    b.HasKey("Id");

                    b.ToTable("RegistrationsAttendanceOrOnline");
                });
#pragma warning restore 612, 618
        }
    }
}
