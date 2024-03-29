﻿// <auto-generated />
using Keep_Calm_Learn_CSHARP.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Keep_Calm_Learn_CSHARP.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220608042603_onetomany")]
    partial class onetomany
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("Keep_Calm_Learn_CSHARP.Models.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Home")
                        .HasColumnType("text");

                    b.Property<int>("StaffId")
                        .HasColumnType("integer");

                    b.Property<string>("Street")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("StaffId")
                        .IsUnique();

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("Keep_Calm_Learn_CSHARP.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Keep_Calm_Learn_CSHARP.Models.OrderDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int>("OrderId")
                        .HasColumnType("integer");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("Keep_Calm_Learn_CSHARP.Models.Staff", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("age")
                        .HasColumnType("integer")
                        .HasColumnName("age");

                    b.Property<string>("email")
                        .HasColumnType("text")
                        .HasColumnName("email");

                    b.Property<string>("firstname")
                        .HasColumnType("text")
                        .HasColumnName("firstname");

                    b.Property<string>("lastname")
                        .HasColumnType("text")
                        .HasColumnName("lastname");

                    b.HasKey("id");

                    b.ToTable("Staffs");
                });

            modelBuilder.Entity("Keep_Calm_Learn_CSHARP.Models.Address", b =>
                {
                    b.HasOne("Keep_Calm_Learn_CSHARP.Models.Staff", "Staff")
                        .WithOne("Address")
                        .HasForeignKey("Keep_Calm_Learn_CSHARP.Models.Address", "StaffId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Staff");
                });

            modelBuilder.Entity("Keep_Calm_Learn_CSHARP.Models.OrderDetails", b =>
                {
                    b.HasOne("Keep_Calm_Learn_CSHARP.Models.Order", "Order")
                        .WithMany("Details")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");
                });

            modelBuilder.Entity("Keep_Calm_Learn_CSHARP.Models.Order", b =>
                {
                    b.Navigation("Details");
                });

            modelBuilder.Entity("Keep_Calm_Learn_CSHARP.Models.Staff", b =>
                {
                    b.Navigation("Address");
                });
#pragma warning restore 612, 618
        }
    }
}
