﻿// <auto-generated />
using Car_Exercise;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Car_Exercise.Migrations
{
    [DbContext(typeof(MyDbContext))]
    partial class MyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Car_Exercise.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Cars", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 8,
                            Brand = "Volvo",
                            Model = "V40",
                            Year = 2020
                        },
                        new
                        {
                            Id = 9,
                            Brand = "SAAB",
                            Model = "900T",
                            Year = 2000
                        },
                        new
                        {
                            Id = 10,
                            Brand = "BMW",
                            Model = "XL500",
                            Year = 2022
                        },
                        new
                        {
                            Id = 3,
                            Brand = "Volvo",
                            Model = "V40",
                            Year = 2020
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
