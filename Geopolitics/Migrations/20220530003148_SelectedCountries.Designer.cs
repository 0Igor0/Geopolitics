﻿// <auto-generated />
using System;
using Geopolitics.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Geopolitics.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220530003148_SelectedCountries")]
    partial class SelectedCountries
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Geopolitics.Models.Continent", b =>
                {
                    b.Property<int>("ContinentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ContinentID"), 1L, 1);

                    b.Property<string>("ContinentName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("ContinentID");

                    b.ToTable("Contnents");
                });

            modelBuilder.Entity("Geopolitics.Models.Country", b =>
                {
                    b.Property<int>("CountryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CountryId"), 1L, 1);

                    b.Property<int>("ContinentID")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<string>("ImgUrl")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<bool>("IsChosen")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<decimal>("Population")
                        .HasColumnType("decimal(10,2)");

                    b.HasKey("CountryId");

                    b.HasIndex("ContinentID");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("Geopolitics.Models.SelectedCountries", b =>
                {
                    b.Property<int>("SelectedCountriesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SelectedCountriesId"), 1L, 1);

                    b.Property<int>("Ammount")
                        .HasColumnType("int");

                    b.Property<int?>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("SelectedId")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("SelectedCountriesId");

                    b.HasIndex("CountryId");

                    b.ToTable("SelectedCountries");
                });

            modelBuilder.Entity("Geopolitics.Models.Country", b =>
                {
                    b.HasOne("Geopolitics.Models.Continent", "Continent")
                        .WithMany("Countries")
                        .HasForeignKey("ContinentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Continent");
                });

            modelBuilder.Entity("Geopolitics.Models.SelectedCountries", b =>
                {
                    b.HasOne("Geopolitics.Models.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryId");

                    b.Navigation("Country");
                });

            modelBuilder.Entity("Geopolitics.Models.Continent", b =>
                {
                    b.Navigation("Countries");
                });
#pragma warning restore 612, 618
        }
    }
}
