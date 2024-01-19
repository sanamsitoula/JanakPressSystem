﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Razor_Temp.Data;

#nullable disable

namespace Razor_Temp.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    [Migration("20240108072522_AddCategorytoDB")]
    partial class AddCategorytoDB
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Razor_Temp.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<bool?>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedBy = "1",
                            CreatedDate = new DateTime(2024, 1, 8, 13, 10, 21, 940, DateTimeKind.Local).AddTicks(7238),
                            Description = "Action",
                            DisplayOrder = 1,
                            Name = "Action",
                            Status = true
                        },
                        new
                        {
                            Id = 2,
                            CreatedBy = "1",
                            CreatedDate = new DateTime(2024, 1, 8, 13, 10, 21, 940, DateTimeKind.Local).AddTicks(7251),
                            Description = "Tamil",
                            DisplayOrder = 3,
                            Name = "Tamil",
                            Status = true
                        },
                        new
                        {
                            Id = 3,
                            CreatedBy = "1",
                            CreatedDate = new DateTime(2024, 1, 8, 13, 10, 21, 940, DateTimeKind.Local).AddTicks(7252),
                            Description = "Animation",
                            DisplayOrder = 2,
                            Name = "Animation",
                            Status = true
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
