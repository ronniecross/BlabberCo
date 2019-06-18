﻿// <auto-generated />
using System;
using BlabberCoCRM.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BlabberCoCRM.Migrations
{
    [DbContext(typeof(CRMContext))]
    [Migration("20190618115911_RemoveAddressFromClient")]
    partial class RemoveAddressFromClient
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BlabberCoCRM.Models.Address", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AddressLine1");

                    b.Property<string>("AddressLine2");

                    b.Property<string>("AddressLine3");

                    b.Property<string>("BuildingName");

                    b.Property<string>("PostCode");

                    b.Property<int>("PropertyNumber");

                    b.HasKey("ID");

                    b.ToTable("Address");
                });

            modelBuilder.Entity("BlabberCoCRM.Models.CSOEmployee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EmailAddress");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("PhoneNumber");

                    b.HasKey("Id");

                    b.ToTable("CSOEmployee");
                });

            modelBuilder.Entity("BlabberCoCRM.Models.Client", b =>
                {
                    b.Property<string>("ID");

                    b.Property<string>("CostCenterCode");

                    b.Property<string>("Name");

                    b.Property<DateTime>("SetupDate");

                    b.HasKey("ID");

                    b.ToTable("Client");
                });

            modelBuilder.Entity("BlabberCoCRM.Models.ClientEmployee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClientID");

                    b.Property<string>("EmailAddress");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("PhoneNumber");

                    b.HasKey("Id");

                    b.HasIndex("ClientID");

                    b.ToTable("ClientEmployee");
                });

            modelBuilder.Entity("BlabberCoCRM.Models.ClientEmployeeAddress", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AddressID");

                    b.Property<int>("ClientEmployeeId");

                    b.HasKey("Id");

                    b.HasIndex("AddressID");

                    b.HasIndex("ClientEmployeeId");

                    b.ToTable("ClientEmployeeAddress");
                });

            modelBuilder.Entity("BlabberCoCRM.Models.ClientEmployeePrimaryAddress", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ClientEmployeeAddressId");

                    b.Property<int>("ClientEmployeeId");

                    b.HasKey("ID");

                    b.HasIndex("ClientEmployeeAddressId");

                    b.HasIndex("ClientEmployeeId")
                        .IsUnique();

                    b.ToTable("ClientEmployeePrimaryAddress");
                });

            modelBuilder.Entity("BlabberCoCRM.Models.ClientToEmployee", b =>
                {
                    b.Property<int>("ClientID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClientEmployeeID");

                    b.Property<string>("ClientID1");

                    b.HasKey("ClientID");

                    b.HasIndex("ClientEmployeeID");

                    b.HasIndex("ClientID1");

                    b.ToTable("ClientToEmployee");
                });

            modelBuilder.Entity("BlabberCoCRM.Models.Communication", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ComType");

                    b.Property<int?>("ConversationId");

                    b.Property<DateTime>("DateTime");

                    b.Property<string>("Description");

                    b.HasKey("Id");

                    b.HasIndex("ConversationId");

                    b.ToTable("Communication");
                });

            modelBuilder.Entity("BlabberCoCRM.Models.Conversation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ClientEmployeeId");

                    b.Property<DateTime>("CloseDateTime");

                    b.Property<string>("Description");

                    b.Property<int?>("InternalEmployeeId");

                    b.Property<DateTime>("OpenDateTime");

                    b.Property<int?>("ProductID");

                    b.Property<string>("Summary");

                    b.Property<int>("status");

                    b.HasKey("Id");

                    b.HasIndex("ClientEmployeeId");

                    b.HasIndex("InternalEmployeeId");

                    b.HasIndex("ProductID");

                    b.ToTable("Conversation");
                });

            modelBuilder.Entity("BlabberCoCRM.Models.InternalEmployee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("InternalEmployee");

                    b.HasDiscriminator<string>("Discriminator").HasValue("InternalEmployee");
                });

            modelBuilder.Entity("BlabberCoCRM.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ClientEmployeeId");

                    b.Property<int>("Discount");

                    b.Property<DateTime>("OrderDate");

                    b.Property<int?>("SalesEmployeeId");

                    b.HasKey("Id");

                    b.HasIndex("ClientEmployeeId");

                    b.HasIndex("SalesEmployeeId");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("BlabberCoCRM.Models.OrderItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<int?>("OrderId");

                    b.Property<int?>("ProductID");

                    b.Property<DateTime>("WarrantyExpiry");

                    b.Property<int>("discount");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductID");

                    b.ToTable("OrderItem");

                    b.HasDiscriminator<string>("Discriminator").HasValue("OrderItem");
                });

            modelBuilder.Entity("BlabberCoCRM.Models.PrimaryClientEmployee", b =>
                {
                    b.Property<string>("ClientID");

                    b.Property<int>("ClientEmployeeID");

                    b.HasKey("ClientID");

                    b.HasIndex("ClientEmployeeID");

                    b.ToTable("PrimaryClientEmployee");
                });

            modelBuilder.Entity("BlabberCoCRM.Models.Product", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<decimal>("Price");

                    b.HasKey("ID");

                    b.ToTable("Product");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Product");
                });

            modelBuilder.Entity("BlabberCoCRM.Models.SalesEmployee", b =>
                {
                    b.HasBaseType("BlabberCoCRM.Models.InternalEmployee");

                    b.HasDiscriminator().HasValue("SalesEmployee");
                });

            modelBuilder.Entity("BlabberCoCRM.Models.ClientService", b =>
                {
                    b.HasBaseType("BlabberCoCRM.Models.OrderItem");

                    b.Property<DateTime>("EndDate");

                    b.Property<DateTime>("StartDate");

                    b.HasDiscriminator().HasValue("ClientService");
                });

            modelBuilder.Entity("BlabberCoCRM.Models.ServiceProduct", b =>
                {
                    b.HasBaseType("BlabberCoCRM.Models.Product");

                    b.Property<int>("DurationDays");

                    b.Property<int>("ServiceProductId");

                    b.Property<string>("Summary");

                    b.HasDiscriminator().HasValue("ServiceProduct");
                });

            modelBuilder.Entity("BlabberCoCRM.Models.TangibleProduct", b =>
                {
                    b.HasBaseType("BlabberCoCRM.Models.Product");

                    b.Property<DateTime>("EndOfLife");

                    b.Property<string>("Manufacture");

                    b.Property<string>("Model");

                    b.Property<int>("TangibleProductId");

                    b.HasDiscriminator().HasValue("TangibleProduct");
                });

            modelBuilder.Entity("BlabberCoCRM.Models.ClientEmployee", b =>
                {
                    b.HasOne("BlabberCoCRM.Models.Client", "Client")
                        .WithMany()
                        .HasForeignKey("ClientID");
                });

            modelBuilder.Entity("BlabberCoCRM.Models.ClientEmployeeAddress", b =>
                {
                    b.HasOne("BlabberCoCRM.Models.Address", "Address")
                        .WithMany("ClientEmployeeAddresses")
                        .HasForeignKey("AddressID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BlabberCoCRM.Models.ClientEmployee", "ClientEmployee")
                        .WithMany("ClientEmployeeAddresses")
                        .HasForeignKey("ClientEmployeeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BlabberCoCRM.Models.ClientEmployeePrimaryAddress", b =>
                {
                    b.HasOne("BlabberCoCRM.Models.ClientEmployeeAddress", "ClientEmployeeAddress")
                        .WithMany()
                        .HasForeignKey("ClientEmployeeAddressId");

                    b.HasOne("BlabberCoCRM.Models.ClientEmployee", "ClientEmployee")
                        .WithOne("ClientEmployeePrimaryAddress")
                        .HasForeignKey("BlabberCoCRM.Models.ClientEmployeePrimaryAddress", "ClientEmployeeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BlabberCoCRM.Models.ClientToEmployee", b =>
                {
                    b.HasOne("BlabberCoCRM.Models.ClientEmployee", "ClientEmployee")
                        .WithMany()
                        .HasForeignKey("ClientEmployeeID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BlabberCoCRM.Models.Client", "Client")
                        .WithMany("ClientToEmployees")
                        .HasForeignKey("ClientID1");
                });

            modelBuilder.Entity("BlabberCoCRM.Models.Communication", b =>
                {
                    b.HasOne("BlabberCoCRM.Models.Conversation", "Conversation")
                        .WithMany("Communications")
                        .HasForeignKey("ConversationId");
                });

            modelBuilder.Entity("BlabberCoCRM.Models.Conversation", b =>
                {
                    b.HasOne("BlabberCoCRM.Models.ClientEmployee", "ClientEmployee")
                        .WithMany("Conversations")
                        .HasForeignKey("ClientEmployeeId");

                    b.HasOne("BlabberCoCRM.Models.InternalEmployee", "InternalEmployee")
                        .WithMany("Conversations")
                        .HasForeignKey("InternalEmployeeId");

                    b.HasOne("BlabberCoCRM.Models.Product", "Product")
                        .WithMany("Conversations")
                        .HasForeignKey("ProductID");
                });

            modelBuilder.Entity("BlabberCoCRM.Models.Order", b =>
                {
                    b.HasOne("BlabberCoCRM.Models.ClientEmployee", "ClientEmployee")
                        .WithMany("Orders")
                        .HasForeignKey("ClientEmployeeId");

                    b.HasOne("BlabberCoCRM.Models.SalesEmployee", "SalesEmployee")
                        .WithMany("Orders")
                        .HasForeignKey("SalesEmployeeId");
                });

            modelBuilder.Entity("BlabberCoCRM.Models.OrderItem", b =>
                {
                    b.HasOne("BlabberCoCRM.Models.Order", "Order")
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderId");

                    b.HasOne("BlabberCoCRM.Models.Product", "Product")
                        .WithMany("OrderItems")
                        .HasForeignKey("ProductID");
                });

            modelBuilder.Entity("BlabberCoCRM.Models.PrimaryClientEmployee", b =>
                {
                    b.HasOne("BlabberCoCRM.Models.ClientEmployee", "ClientEmployee")
                        .WithMany()
                        .HasForeignKey("ClientEmployeeID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BlabberCoCRM.Models.Client", "Client")
                        .WithOne("PrimaryClientEmployee")
                        .HasForeignKey("BlabberCoCRM.Models.PrimaryClientEmployee", "ClientID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
