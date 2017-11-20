using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using LicenCePlateApp.Entities;

namespace LicenCePlateApp.Migrations
{
    [DbContext(typeof(LicencePlateContext))]
    [Migration("20171120140046_initialmigration")]
    partial class initialmigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LicenCePlateApp.Models.LicencePlate", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Brand");

                    b.Property<string>("Color");

                    b.Property<string>("Model");

                    b.Property<string>("Plate");

                    b.Property<int>("Year");

                    b.HasKey("Id");

                    b.ToTable("LicencePlates");
                });
        }
    }
}
