﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Shop.Data;

#nullable disable

namespace Shop.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240520173839_Migration1")]
    partial class Migration1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Shop.Core.Entities.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("AshrayDetails")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Shop.Core.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Barcode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Kategory")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int?>("ShoppingId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ShoppingId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Shop.Core.Entities.Shopping", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("PasswordCustomer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("PricePaying")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Shoppings");
                });

            modelBuilder.Entity("Shop.Core.Entities.Product", b =>
                {
                    b.HasOne("Shop.Core.Entities.Shopping", null)
                        .WithMany("Products")
                        .HasForeignKey("ShoppingId");
                });

            modelBuilder.Entity("Shop.Core.Entities.Shopping", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}