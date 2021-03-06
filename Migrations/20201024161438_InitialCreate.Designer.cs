﻿// <auto-generated />
using AdvisorRegistrationWebApi.Models.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AdvisorRegistrationWebApi.Migrations
{
    [DbContext(typeof(AdvisorDbContext))]
    [Migration("20201024161438_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AdvisorRegistrationWebApi.Models.Advisor", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("fullName")
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("memberSince")
                        .HasColumnType("int");

                    b.Property<string>("mobile")
                        .HasColumnType("nvarchar(16)");

                    b.Property<int>("registryNumber")
                        .HasColumnType("int");

                    b.Property<bool>("status")
                        .HasColumnType("bit");

                    b.HasKey("id");

                    b.ToTable("Advisors");
                });
#pragma warning restore 612, 618
        }
    }
}
