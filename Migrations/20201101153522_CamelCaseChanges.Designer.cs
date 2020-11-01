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
    [Migration("20201101153522_CamelCaseChanges")]
    partial class CamelCaseChanges
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AdvisorRegistrationWebApi.Models.Advisor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Mobile")
                        .HasColumnType("nvarchar(16)");

                    b.Property<int>("RegistryNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Advisors");
                });
#pragma warning restore 612, 618
        }
    }
}
