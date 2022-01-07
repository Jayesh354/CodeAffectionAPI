﻿// <auto-generated />
using CodeAffection_Tutorial_Demo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace CodeAffection_Tutorial_Demo.Migrations
{
    [DbContext(typeof(PaymentDetailsDbContext))]
    partial class PaymentDetailsDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityByDefaultColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("CodeAffection_Tutorial_Demo.Models.PaymentDetails", b =>
                {
                    b.Property<int>("PaymentDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("CardNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("CardOwnerName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ExpirationDate")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("SecurityCode")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("PaymentDetailId");

                    b.ToTable("PaymentDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
