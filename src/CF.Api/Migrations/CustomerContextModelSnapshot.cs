﻿// <auto-generated />

using System;
using CF.Customer.Infrastructure.DbContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace CF.Api.Migrations
{
    [DbContext(typeof(CustomerContext))]
    internal class CustomerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0-rc.2.20475.6");

            modelBuilder.Entity("CF.Customer.Domain.Entities.Customer", b =>
            {
                b.Property<long>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("bigint")
                    .UseIdentityColumn();

                b.Property<DateTime>("Created")
                    .HasColumnType("datetime2");

                b.Property<string>("Email")
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnType("nvarchar(100)");

                b.Property<string>("FirstName")
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnType("nvarchar(100)");

                b.Property<string>("Password")
                    .IsRequired()
                    .HasMaxLength(2000)
                    .HasColumnType("nvarchar(2000)");

                b.Property<string>("Surname")
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnType("nvarchar(100)");

                b.Property<DateTime?>("Updated")
                    .HasColumnType("datetime2");

                b.HasKey("Id");

                b.HasIndex("Email")
                    .IsUnique();

                b.ToTable("Customer");
            });
#pragma warning restore 612, 618
        }
    }
}