﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Sample.Api.Data;

#nullable disable

namespace Sample.Api.Migrations
{
    [DbContext(typeof(SampleApiContext))]
    [Migration("20230510135144_mssql.local_migration_579")]
    partial class mssqllocal_migration_579
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Sample.Api.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Product");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Category = "Personal Hygiene",
                            Description = "Lovely shampoo for your hair",
                            Name = "Super Shampoo"
                        },
                        new
                        {
                            Id = 2,
                            Category = "Personal Hygiene",
                            Description = "Great for cleaning hands",
                            Name = "Super Hand Soap"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
