﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ServerApi.Data;

namespace ServerApi.Migrations
{
    [DbContext(typeof(DbStorageContext))]
    [Migration("20200831192726_NewMigration")]
    partial class NewMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ServerApi.Models.SensorsReadingEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("HumidityValue")
                        .HasColumnType("int");

                    b.Property<long>("ReadTimeMilis")
                        .HasColumnType("bigint");

                    b.Property<float>("TemperatureValue")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.ToTable("SensorsReadEntities");
                });
#pragma warning restore 612, 618
        }
    }
}