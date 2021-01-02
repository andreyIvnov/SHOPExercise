﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SHOPExercise.Data;

namespace SHOPExercise.Migrations
{
    [DbContext(typeof(ProductsDBContext))]
    [Migration("20201230110742_InitDb")]
    partial class InitDb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SHOPExercise.Models.Product", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Photo");

                    b.Property<double>("Price");

                    b.HasKey("ID");

                    b.ToTable("Products");

                    b.HasData(
                        new { ID = 1, Description = "Fish Scales :)", Name = "Scale", Photo = "https://img.likeness.ru/83/62/8362/1439702784.jpg", Price = 50.0 },
                        new { ID = 2, Description = "Fantastic Troll ass", Name = "Troll ass", Photo = "https://www.jeremyriad.com/wp-content/uploads/2017/03/Trump_Troll_Doll4-550x698.jpeg", Price = 300.0 }
                    );
                });
#pragma warning restore 612, 618
        }
    }
}
