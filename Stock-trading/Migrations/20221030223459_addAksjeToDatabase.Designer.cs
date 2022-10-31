﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Stock_trading.Models;

namespace Stock_trading.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20221030223459_addAksjeToDatabase")]
    partial class addAksjeToDatabase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.30")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Stock_trading.Models.Aksje", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Antall")
                        .HasColumnType("float");

                    b.Property<int>("Navn")
                        .HasColumnType("int");

                    b.Property<double>("Pris")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Aksjer");
                });
#pragma warning restore 612, 618
        }
    }
}
