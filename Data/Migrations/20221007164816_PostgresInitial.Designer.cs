﻿// <auto-generated />
using System;
using Hughmail.Api.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Hughmail.Api.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20221007164816_PostgresInitial")]
    partial class PostgresInitial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Hughmail.Api.Entities.Email", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Body")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<int>("SenderUserId")
                        .HasColumnType("integer");

                    b.Property<int>("StatusId")
                        .HasColumnType("integer");

                    b.Property<string>("Subject")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Emails");
                });
#pragma warning restore 612, 618
        }
    }
}
