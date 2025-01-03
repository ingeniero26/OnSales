﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OnSales.Web.Data;

#nullable disable

namespace OnSales.Web.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20250103004823_indexCompuesto")]
    partial class indexCompuesto
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("OnSales.Web.Data.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("NameCategory")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("NameCategory")
                        .IsUnique();

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("OnSales.Web.Data.Entities.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("StateId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.HasIndex("StateId");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("OnSales.Web.Data.Entities.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("NameCountry")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("NameCountry")
                        .IsUnique();

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("OnSales.Web.Data.Entities.State", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.HasIndex("Name", "CountryId")
                        .IsUnique();

                    b.ToTable("Statements");
                });

            modelBuilder.Entity("OnSales.Web.Data.Entities.Taxes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("TaxesTypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TaxesTypeId");

                    b.ToTable("Taxes");
                });

            modelBuilder.Entity("OnSales.Web.Data.Entities.TaxesType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("NameTaxesType")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("NameTaxesType")
                        .IsUnique();

                    b.ToTable("TaxeTypes");
                });

            modelBuilder.Entity("OnSales.Web.Data.Entities.City", b =>
                {
                    b.HasOne("OnSales.Web.Data.Entities.State", "State")
                        .WithMany("Cities")
                        .HasForeignKey("StateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("State");
                });

            modelBuilder.Entity("OnSales.Web.Data.Entities.State", b =>
                {
                    b.HasOne("OnSales.Web.Data.Entities.Country", "Country")
                        .WithMany("States")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("OnSales.Web.Data.Entities.Taxes", b =>
                {
                    b.HasOne("OnSales.Web.Data.Entities.TaxesType", "TaxesType")
                        .WithMany("Taxes")
                        .HasForeignKey("TaxesTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TaxesType");
                });

            modelBuilder.Entity("OnSales.Web.Data.Entities.Country", b =>
                {
                    b.Navigation("States");
                });

            modelBuilder.Entity("OnSales.Web.Data.Entities.State", b =>
                {
                    b.Navigation("Cities");
                });

            modelBuilder.Entity("OnSales.Web.Data.Entities.TaxesType", b =>
                {
                    b.Navigation("Taxes");
                });
#pragma warning restore 612, 618
        }
    }
}
