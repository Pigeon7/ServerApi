﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ServerApi.Data;

namespace ServerApi.Migrations
{
    [DbContext(typeof(DbStorageContext))]
    partial class RaspStorageContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ServerApi.Models.TempAndHumidReadEntity", b =>
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

                    b.ToTable("TempAndHumidEntities");
                });
#pragma warning restore 612, 618
        }
    }
}
