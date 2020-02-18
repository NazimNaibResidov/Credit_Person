﻿// <auto-generated />
using System;
using Banks.Entity.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Banks.ApiUI.Migrations
{
    [DbContext(typeof(BankDbContext))]
    [Migration("20200218162420_addedFile")]
    partial class addedFile
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Banks.Entity.Data.Credit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Amount");

                    b.Property<DateTime>("EndDate");

                    b.Property<DateTime>("StartDate");

                    b.HasKey("Id");

                    b.ToTable("Credits");
                });

            modelBuilder.Entity("Banks.Entity.Data.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CreditId");

                    b.Property<string>("Email")
                        .HasMaxLength(20);

                    b.Property<string>("Name")
                        .HasMaxLength(15);

                    b.Property<string>("Surname")
                        .HasMaxLength(20);

                    b.Property<string>("passnum")
                        .HasMaxLength(25);

                    b.HasKey("Id");

                    b.HasIndex("CreditId");

                    b.ToTable("People");
                });

            modelBuilder.Entity("Banks.Entity.Data.Person", b =>
                {
                    b.HasOne("Banks.Entity.Data.Credit", "Credit")
                        .WithMany("People")
                        .HasForeignKey("CreditId");
                });
#pragma warning restore 612, 618
        }
    }
}
