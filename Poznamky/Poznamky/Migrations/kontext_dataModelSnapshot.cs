// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Poznamky.Data;

#nullable disable

namespace Poznamky.Migrations
{
    [DbContext(typeof(kontext_data))]
    partial class kontext_dataModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Poznamky.Models.poznamka", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CasPridani")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nadpis")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("dulezita_poznamka")
                        .HasColumnType("bit");

                    b.Property<string>("jmeno")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Novinky");
                });

            modelBuilder.Entity("Poznamky.Models.pripojeni", b =>
                {
                    b.Property<string>("jmeno")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("heslo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("jmeno");

                    b.ToTable("Pristup");
                });
#pragma warning restore 612, 618
        }
    }
}
