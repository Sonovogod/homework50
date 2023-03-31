﻿// <auto-generated />
using System;
using HomeWork.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HomeWork.Migrations
{
    [DbContext(typeof(FoodContext))]
    [Migration("20230331183913_rechange weight prop type in seaFood")]
    partial class rechangeweightproptypeinseaFood
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.15");

            modelBuilder.Entity("HomeWork.Models.CustomerOrder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Adress")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("SeaFoodId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("SeaFoodId");

                    b.ToTable("CustomerOrders");
                });

            modelBuilder.Entity("HomeWork.Models.SeaFood", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Coast")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("ExpirationDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Weight")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("SeaFoods");
                });

            modelBuilder.Entity("HomeWork.Models.CustomerOrder", b =>
                {
                    b.HasOne("HomeWork.Models.SeaFood", "SeaFood")
                        .WithMany()
                        .HasForeignKey("SeaFoodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SeaFood");
                });
#pragma warning restore 612, 618
        }
    }
}
