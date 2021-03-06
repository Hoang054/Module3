﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using exercise.Models;

namespace exercise.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20200826014048_seedingCustomerData")]
    partial class seedingCustomerData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("exercise.Models.Customer", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AvatarPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConfirmPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("idDistrict")
                        .HasColumnType("int");

                    b.Property<int>("idProvince")
                        .HasColumnType("int");

                    b.Property<int>("idWard")
                        .HasColumnType("int");

                    b.Property<string>("numberPhone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            id = 1,
                            ConfirmPassword = "Qwerty!23",
                            Email = "xuanhoang054@gmail.com",
                            FullName = "Hoang Tran",
                            Password = "Qwerty!23",
                            idDistrict = 1,
                            idProvince = 2,
                            idWard = 3,
                            numberPhone = "0123456789"
                        });
                });

            modelBuilder.Entity("exercise.Models.District", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("_prefix")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("_province_id")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("districts");
                });

            modelBuilder.Entity("exercise.Models.Province", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("_code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("_name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("provinces");
                });

            modelBuilder.Entity("exercise.Models.Ward", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("_district_id")
                        .HasColumnType("int");

                    b.Property<string>("_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("_prefix")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("_province_id")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("wards");
                });
#pragma warning restore 612, 618
        }
    }
}
