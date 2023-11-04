﻿// <auto-generated />
using System;
using MegaDesk_2._0.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MegaDesk_2._0.Migrations
{
    [DbContext(typeof(MegaDesk_2_0Context))]
    [Migration("20231104144436_Desk")]
    partial class Desk
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MegaDesk_2._0.Models.Desk", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("drawers")
                        .HasColumnType("int");

                    b.Property<int?>("height")
                        .HasColumnType("int");

                    b.Property<string>("material")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float?>("price")
                        .HasColumnType("real");

                    b.Property<int>("rushOrder")
                        .HasColumnType("int");

                    b.Property<int?>("width")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Desks");
                });
#pragma warning restore 612, 618
        }
    }
}
