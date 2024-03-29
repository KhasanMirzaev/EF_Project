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
    [Migration("20220606093511_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

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
#pragma warning restore 612, 618
        }
    }
}
