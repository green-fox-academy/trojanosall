using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using MyBudgetApp.Entities;
using MyBudgetApp.Models;

namespace MyBudgetApp.Migrations
{
    [DbContext(typeof(MyBudgetContext))]
    [Migration("20171110105343_initialmigration")]
    partial class initialmigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MyBudgetApp.Models.Expense", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Amount");

                    b.Property<int>("Category");

                    b.Property<DateTime>("Date");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("Expenses");
                });
        }
    }
}
