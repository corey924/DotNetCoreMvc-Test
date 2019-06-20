﻿// <auto-generated />
using System;
using dotNetCore.Services.Database.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace dotNetCore.Services.Migrations
{
    [DbContext(typeof(Database.Entity.EntityDbContext))]
    [Migration("20190613102456_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("dotNetCore.Services.Database.Models.User", b =>
                {
                    b.Property<Guid>("Gid")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Account")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Email")
                        .HasMaxLength(50);

                    b.Property<int>("Enable");

                    b.Property<string>("Mobile")
                        .HasMaxLength(20);

                    b.Property<string>("NickName")
                        .HasMaxLength(20);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("Role");

                    b.Property<int>("Sex");

                    b.Property<DateTime>("UpdatedAt");

                    b.HasKey("Gid");

                    b.ToTable("User");
                });
#pragma warning restore 612, 618
        }
    }
}