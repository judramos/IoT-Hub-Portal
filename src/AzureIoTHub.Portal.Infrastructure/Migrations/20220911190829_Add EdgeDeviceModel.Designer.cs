﻿// <auto-generated />
using System;
using AzureIoTHub.Portal.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace AzureIoTHub.Portal.Infrastructure.Migrations
{
    [DbContext(typeof(PortalDbContext))]
    [Migration("20220911190829_Add EdgeDeviceModel")]
    partial class AddEdgeDeviceModel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("AzureIoTHub.Portal.Domain.Entities.DeviceModel", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<bool?>("ABPRelaxMode")
                        .HasColumnType("boolean");

                    b.Property<string>("AppEUI")
                        .HasColumnType("text");

                    b.Property<int?>("Deduplication")
                        .HasColumnType("integer");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<bool?>("Downlink")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsBuiltin")
                        .HasColumnType("boolean");

                    b.Property<int?>("KeepAliveTimeout")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("PreferredWindow")
                        .HasColumnType("integer");

                    b.Property<int?>("RXDelay")
                        .HasColumnType("integer");

                    b.Property<string>("SensorDecoder")
                        .HasColumnType("text");

                    b.Property<bool>("SupportLoRaFeatures")
                        .HasColumnType("boolean");

                    b.Property<bool?>("UseOTAA")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.ToTable("DeviceModels");
                });

            modelBuilder.Entity("AzureIoTHub.Portal.Domain.Entities.DeviceModelCommand", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<bool>("Confirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("DeviceModelId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Frame")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsBuiltin")
                        .HasColumnType("boolean");

                    b.Property<int>("Port")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("DeviceModelCommands");
                });

            modelBuilder.Entity("AzureIoTHub.Portal.Domain.Entities.DeviceModelProperty", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("DisplayName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsWritable")
                        .HasColumnType("boolean");

                    b.Property<string>("ModelId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Order")
                        .HasColumnType("integer");

                    b.Property<int>("PropertyType")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("DeviceModelProperties");
                });

            modelBuilder.Entity("AzureIoTHub.Portal.Domain.Entities.DeviceTag", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("Label")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("Required")
                        .HasColumnType("boolean");

                    b.Property<bool>("Searchable")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.ToTable("DeviceTags");
                });

            modelBuilder.Entity("AzureIoTHub.Portal.Domain.Entities.EdgeDeviceModel", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("EdgeDeviceModels");
                });

            modelBuilder.Entity("AzureIoTHub.Portal.Domain.Entities.EdgeDeviceModelCommand", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("EdgeDeviceModelId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("EdgeDeviceModelCommands");
                });
#pragma warning restore 612, 618
        }
    }
}
