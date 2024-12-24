﻿// <auto-generated />
using System;
using BackendApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BackendApi.Migrations
{
    [DbContext(typeof(SoftwareSalesContext))]
    [Migration("20241220083820_MigratonName")]
    partial class MigratonName
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BackendApi.Models.AdminAction", b =>
                {
                    b.Property<int>("ActionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ActionID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ActionId"));

                    b.Property<DateTime?>("ActionDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<string>("ActionDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("AdminId")
                        .HasColumnType("int")
                        .HasColumnName("AdminID");

                    b.HasKey("ActionId")
                        .HasName("PK__AdminAct__FFE3F4B941724670");

                    b.HasIndex("AdminId");

                    b.ToTable("AdminActions");
                });

            modelBuilder.Entity("BackendApi.Models.Cart", b =>
                {
                    b.Property<int>("CartId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("CartID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CartId"));

                    b.Property<int>("ProductId")
                        .HasColumnType("int")
                        .HasColumnName("ProductID");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("UserID");

                    b.HasKey("CartId")
                        .HasName("PK__Cart__51BCD7972C7B36B9");

                    b.HasIndex("ProductId");

                    b.HasIndex("UserId");

                    b.ToTable("Cart", (string)null);
                });

            modelBuilder.Entity("BackendApi.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("CategoryID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId")
                        .HasName("PK__Categori__19093A2B00D7BAB2");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("BackendApi.Models.License", b =>
                {
                    b.Property<int>("LicenseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("LicenseID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LicenseId"));

                    b.Property<DateTime?>("ActivatedAt")
                        .HasColumnType("datetime");

                    b.Property<bool?>("IsActivated")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<string>("LicenseKey")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int")
                        .HasColumnName("ProductID");

                    b.HasKey("LicenseId")
                        .HasName("PK__Licenses__72D600A276F7C5AB");

                    b.HasIndex("ProductId");

                    b.HasIndex(new[] { "LicenseKey" }, "UQ__Licenses__45E1DD6FBDC9CA91")
                        .IsUnique();

                    b.ToTable("Licenses");
                });

            modelBuilder.Entity("BackendApi.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("OrderID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderId"));

                    b.Property<DateTime?>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<string>("OrderStatus")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasDefaultValue("Pending");

                    b.Property<decimal>("TotalAmount")
                        .HasColumnType("decimal(10, 2)");

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("UserID");

                    b.HasKey("OrderId")
                        .HasName("PK__Orders__C3905BAF0663F61E");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("BackendApi.Models.OrderDetail", b =>
                {
                    b.Property<int>("OrderDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("OrderDetailID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderDetailId"));

                    b.Property<int>("OrderId")
                        .HasColumnType("int")
                        .HasColumnName("OrderID");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(10, 2)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int")
                        .HasColumnName("ProductID");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("OrderDetailId")
                        .HasName("PK__OrderDet__D3B9D30C5C39F40A");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("BackendApi.Models.Payment", b =>
                {
                    b.Property<int>("PaymentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("PaymentID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PaymentId"));

                    b.Property<int>("OrderId")
                        .HasColumnType("int")
                        .HasColumnName("OrderID");

                    b.Property<DateTime?>("PaidAt")
                        .HasColumnType("datetime");

                    b.Property<string>("PaymentMethod")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PaymentStatus")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasDefaultValue("Pending");

                    b.HasKey("PaymentId")
                        .HasName("PK__Payments__9B556A5857AC33A9");

                    b.HasIndex("OrderId");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("BackendApi.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ProductID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"));

                    b.Property<string>("Category")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int")
                        .HasColumnName("CategoryID");

                    b.Property<DateTime?>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(10, 2)");

                    b.HasKey("ProductId")
                        .HasName("PK__Products__B40CC6ED8F3753F4");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("BackendApi.Models.Review", b =>
                {
                    b.Property<int>("ReviewId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ReviewID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReviewId"));

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<int>("ProductId")
                        .HasColumnType("int")
                        .HasColumnName("ProductID");

                    b.Property<int?>("Rating")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("UserID");

                    b.HasKey("ReviewId")
                        .HasName("PK__Reviews__74BC79AE2051822D");

                    b.HasIndex("ProductId");

                    b.HasIndex("UserId");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("BackendApi.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("UserID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<DateTime?>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Role")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasDefaultValue("Customer");

                    b.HasKey("UserId")
                        .HasName("PK__Users__1788CCAC20F02140");

                    b.HasIndex(new[] { "Email" }, "UQ__Users__A9D105345C5F50E0")
                        .IsUnique();

                    b.ToTable("Users");
                });

            modelBuilder.Entity("BackendApi.Models.AdminAction", b =>
                {
                    b.HasOne("BackendApi.Models.User", "Admin")
                        .WithMany("AdminActions")
                        .HasForeignKey("AdminId")
                        .IsRequired()
                        .HasConstraintName("FK__AdminActi__Admin__5CD6CB2B");

                    b.Navigation("Admin");
                });

            modelBuilder.Entity("BackendApi.Models.Cart", b =>
                {
                    b.HasOne("BackendApi.Models.Product", "Product")
                        .WithMany("Carts")
                        .HasForeignKey("ProductId")
                        .IsRequired()
                        .HasConstraintName("FK__Cart__ProductID__5535A963");

                    b.HasOne("BackendApi.Models.User", "User")
                        .WithMany("Carts")
                        .HasForeignKey("UserId")
                        .IsRequired()
                        .HasConstraintName("FK__Cart__UserID__5441852A");

                    b.Navigation("Product");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BackendApi.Models.License", b =>
                {
                    b.HasOne("BackendApi.Models.Product", "Product")
                        .WithMany("Licenses")
                        .HasForeignKey("ProductId")
                        .IsRequired()
                        .HasConstraintName("FK__Licenses__Produc__4BAC3F29");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("BackendApi.Models.Order", b =>
                {
                    b.HasOne("BackendApi.Models.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .IsRequired()
                        .HasConstraintName("FK__Orders__UserID__4316F928");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BackendApi.Models.OrderDetail", b =>
                {
                    b.HasOne("BackendApi.Models.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .IsRequired()
                        .HasConstraintName("FK__OrderDeta__Order__45F365D3");

                    b.HasOne("BackendApi.Models.Product", "Product")
                        .WithMany("OrderDetails")
                        .HasForeignKey("ProductId")
                        .IsRequired()
                        .HasConstraintName("FK__OrderDeta__Produ__46E78A0C");

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("BackendApi.Models.Payment", b =>
                {
                    b.HasOne("BackendApi.Models.Order", "Order")
                        .WithMany("Payments")
                        .HasForeignKey("OrderId")
                        .IsRequired()
                        .HasConstraintName("FK__Payments__OrderI__59063A47");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("BackendApi.Models.Product", b =>
                {
                    b.HasOne("BackendApi.Models.Category", "CategoryNavigation")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .HasConstraintName("FK_Products_Categories");

                    b.Navigation("CategoryNavigation");
                });

            modelBuilder.Entity("BackendApi.Models.Review", b =>
                {
                    b.HasOne("BackendApi.Models.Product", "Product")
                        .WithMany("Reviews")
                        .HasForeignKey("ProductId")
                        .IsRequired()
                        .HasConstraintName("FK__Reviews__Product__5070F446");

                    b.HasOne("BackendApi.Models.User", "User")
                        .WithMany("Reviews")
                        .HasForeignKey("UserId")
                        .IsRequired()
                        .HasConstraintName("FK__Reviews__UserID__5165187F");

                    b.Navigation("Product");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BackendApi.Models.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("BackendApi.Models.Order", b =>
                {
                    b.Navigation("OrderDetails");

                    b.Navigation("Payments");
                });

            modelBuilder.Entity("BackendApi.Models.Product", b =>
                {
                    b.Navigation("Carts");

                    b.Navigation("Licenses");

                    b.Navigation("OrderDetails");

                    b.Navigation("Reviews");
                });

            modelBuilder.Entity("BackendApi.Models.User", b =>
                {
                    b.Navigation("AdminActions");

                    b.Navigation("Carts");

                    b.Navigation("Orders");

                    b.Navigation("Reviews");
                });
#pragma warning restore 612, 618
        }
    }
}
