﻿// <auto-generated />
using Carsales.VehicleManagementSystem.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Carsales.VehicleManagementSystem.Data.Migrations
{
    [DbContext(typeof(VehicleContext))]
    [Migration("20201025091208_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Carsales.VehicleManagementSystem.Data.DbEntities.VehicleDb", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BodyType");

                    b.Property<short>("Doors");

                    b.Property<string>("Engine");

                    b.Property<string>("Make");

                    b.Property<string>("Model");

                    b.Property<int>("VehicleType");

                    b.Property<short>("Wheels");

                    b.HasKey("Id");

                    b.ToTable("Vehicle");
                });
#pragma warning restore 612, 618
        }
    }
}
