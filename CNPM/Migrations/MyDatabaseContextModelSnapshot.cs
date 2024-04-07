﻿// <auto-generated />
using System;
using CNPM.Controller;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CNPM.Migrations
{
    [DbContext(typeof(MyDatabaseContext))]
    partial class MyDatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.28")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("CNPM.Model.Account", b =>
                {
                    b.Property<string>("UserName")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("AvatarUrl")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("HashedPassword")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("UserName");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Account");
                });

            modelBuilder.Entity("CNPM.Model.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("CNPM.Model.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CustomerUserId")
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("EmployeeUserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("TotalPrice")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CustomerUserId");

                    b.HasIndex("EmployeeUserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("CNPM.Model.OrderItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("CNPM.Model.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("categoryId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("categoryId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("CNPM.Model.User", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("BirthDay")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("UserId");

                    b.ToTable("Users");

                    b.HasDiscriminator<string>("Discriminator").HasValue("User");
                });

            modelBuilder.Entity("CNPM.Model.Customer", b =>
                {
                    b.HasBaseType("CNPM.Model.User");

                    b.HasDiscriminator().HasValue("Customer");
                });

            modelBuilder.Entity("CNPM.Model.Employee", b =>
                {
                    b.HasBaseType("CNPM.Model.User");

                    b.Property<string>("ApplyDate")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("IdCard")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<long>("Salary")
                        .HasColumnType("bigint");

                    b.Property<string>("WorkingTime")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasDiscriminator().HasValue("Employee");
                });

            modelBuilder.Entity("CNPM.Model.Account", b =>
                {
                    b.HasOne("CNPM.Model.User", "User")
                        .WithOne("Account")
                        .HasForeignKey("CNPM.Model.Account", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("CNPM.Model.Order", b =>
                {
                    b.HasOne("CNPM.Model.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerUserId");

                    b.HasOne("CNPM.Model.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeUserId");

                    b.Navigation("Customer");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("CNPM.Model.OrderItem", b =>
                {
                    b.HasOne("CNPM.Model.Order", "Order")
                        .WithMany("Products")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CNPM.Model.Product", "Product")
                        .WithMany("OrderItems")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("CNPM.Model.Product", b =>
                {
                    b.HasOne("CNPM.Model.Category", "category")
                        .WithMany("Products")
                        .HasForeignKey("categoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("category");
                });

            modelBuilder.Entity("CNPM.Model.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("CNPM.Model.Order", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("CNPM.Model.Product", b =>
                {
                    b.Navigation("OrderItems");
                });

            modelBuilder.Entity("CNPM.Model.User", b =>
                {
                    b.Navigation("Account")
                        .IsRequired();
                });

            modelBuilder.Entity("CNPM.Model.Customer", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
