﻿using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlabberCoCRM.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BuildingName = table.Column<string>(nullable: true),
                    PropertyNumber = table.Column<int>(nullable: false),
                    AddressLine1 = table.Column<string>(nullable: true),
                    AddressLine2 = table.Column<string>(nullable: true),
                    AddressLine3 = table.Column<string>(nullable: true),
                    PostCode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CSOEmployee",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    EmailAddress = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CSOEmployee", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InternalEmployee",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Discriminator = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InternalEmployee", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Price = table.Column<decimal>(nullable: false),
                    Discriminator = table.Column<string>(nullable: false),
                    ServiceProductId = table.Column<int>(nullable: true),
                    Summary = table.Column<string>(nullable: true),
                    DurationDays = table.Column<int>(nullable: true),
                    TangibleProductId = table.Column<int>(nullable: true),
                    Manufacture = table.Column<string>(nullable: true),
                    Model = table.Column<string>(nullable: true),
                    EndOfLife = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    SetupDate = table.Column<DateTime>(nullable: false),
                    CostCenterCode = table.Column<string>(nullable: true),
                    AddressID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Client_Address_AddressID",
                        column: x => x.AddressID,
                        principalTable: "Address",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClientEmployee",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    EmailAddress = table.Column<string>(nullable: true),
                    ClientID = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientEmployee", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClientEmployee_Client_ClientID",
                        column: x => x.ClientID,
                        principalTable: "Client",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ClientEmployeeAddress",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClientEmployeeId = table.Column<int>(nullable: false),
                    AddressID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientEmployeeAddress", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClientEmployeeAddress_Address_AddressID",
                        column: x => x.AddressID,
                        principalTable: "Address",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClientEmployeeAddress_ClientEmployee_ClientEmployeeId",
                        column: x => x.ClientEmployeeId,
                        principalTable: "ClientEmployee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClientToEmployee",
                columns: table => new
                {
                    ClientID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClientID1 = table.Column<string>(nullable: true),
                    ClientEmployeeID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientToEmployee", x => x.ClientID);
                    table.ForeignKey(
                        name: "FK_ClientToEmployee_ClientEmployee_ClientEmployeeID",
                        column: x => x.ClientEmployeeID,
                        principalTable: "ClientEmployee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClientToEmployee_Client_ClientID1",
                        column: x => x.ClientID1,
                        principalTable: "Client",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Conversation",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Summary = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    status = table.Column<int>(nullable: false),
                    OpenDateTime = table.Column<DateTime>(nullable: false),
                    CloseDateTime = table.Column<DateTime>(nullable: false),
                    ProductID = table.Column<int>(nullable: true),
                    InternalEmployeeId = table.Column<int>(nullable: true),
                    ClientEmployeeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conversation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Conversation_ClientEmployee_ClientEmployeeId",
                        column: x => x.ClientEmployeeId,
                        principalTable: "ClientEmployee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Conversation_InternalEmployee_InternalEmployeeId",
                        column: x => x.InternalEmployeeId,
                        principalTable: "InternalEmployee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Conversation_Product_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Product",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    OrderDate = table.Column<DateTime>(nullable: false),
                    Discount = table.Column<int>(nullable: false),
                    SalesEmployeeId = table.Column<int>(nullable: true),
                    ClientEmployeeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Order_ClientEmployee_ClientEmployeeId",
                        column: x => x.ClientEmployeeId,
                        principalTable: "ClientEmployee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Order_InternalEmployee_SalesEmployeeId",
                        column: x => x.SalesEmployeeId,
                        principalTable: "InternalEmployee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PrimaryClientEmployee",
                columns: table => new
                {
                    ClientID = table.Column<string>(nullable: false),
                    ClientEmployeeID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrimaryClientEmployee", x => x.ClientID);
                    table.ForeignKey(
                        name: "FK_PrimaryClientEmployee_ClientEmployee_ClientEmployeeID",
                        column: x => x.ClientEmployeeID,
                        principalTable: "ClientEmployee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PrimaryClientEmployee_Client_ClientID",
                        column: x => x.ClientID,
                        principalTable: "Client",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClientEmployeePrimaryAddress",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClientEmployeeId = table.Column<int>(nullable: false),
                    ClientEmployeeAddressId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientEmployeePrimaryAddress", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ClientEmployeePrimaryAddress_ClientEmployeeAddress_ClientEmployeeAddressId",
                        column: x => x.ClientEmployeeAddressId,
                        principalTable: "ClientEmployeeAddress",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ClientEmployeePrimaryAddress_ClientEmployee_ClientEmployeeId",
                        column: x => x.ClientEmployeeId,
                        principalTable: "ClientEmployee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Communication",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(nullable: true),
                    DateTime = table.Column<DateTime>(nullable: false),
                    ComType = table.Column<int>(nullable: false),
                    ConversationId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Communication", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Communication_Conversation_ConversationId",
                        column: x => x.ConversationId,
                        principalTable: "Conversation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrderItem",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    WarrantyExpiry = table.Column<DateTime>(nullable: false),
                    discount = table.Column<int>(nullable: false),
                    OrderId = table.Column<int>(nullable: true),
                    ProductID = table.Column<int>(nullable: true),
                    Discriminator = table.Column<string>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: true),
                    EndDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderItem_Order_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Order",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderItem_Product_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Product",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Client_AddressID",
                table: "Client",
                column: "AddressID");

            migrationBuilder.CreateIndex(
                name: "IX_ClientEmployee_ClientID",
                table: "ClientEmployee",
                column: "ClientID");

            migrationBuilder.CreateIndex(
                name: "IX_ClientEmployeeAddress_AddressID",
                table: "ClientEmployeeAddress",
                column: "AddressID");

            migrationBuilder.CreateIndex(
                name: "IX_ClientEmployeeAddress_ClientEmployeeId",
                table: "ClientEmployeeAddress",
                column: "ClientEmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_ClientEmployeePrimaryAddress_ClientEmployeeAddressId",
                table: "ClientEmployeePrimaryAddress",
                column: "ClientEmployeeAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_ClientEmployeePrimaryAddress_ClientEmployeeId",
                table: "ClientEmployeePrimaryAddress",
                column: "ClientEmployeeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ClientToEmployee_ClientEmployeeID",
                table: "ClientToEmployee",
                column: "ClientEmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_ClientToEmployee_ClientID1",
                table: "ClientToEmployee",
                column: "ClientID1");

            migrationBuilder.CreateIndex(
                name: "IX_Communication_ConversationId",
                table: "Communication",
                column: "ConversationId");

            migrationBuilder.CreateIndex(
                name: "IX_Conversation_ClientEmployeeId",
                table: "Conversation",
                column: "ClientEmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Conversation_InternalEmployeeId",
                table: "Conversation",
                column: "InternalEmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Conversation_ProductID",
                table: "Conversation",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_Order_ClientEmployeeId",
                table: "Order",
                column: "ClientEmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_SalesEmployeeId",
                table: "Order",
                column: "SalesEmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_OrderId",
                table: "OrderItem",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_ProductID",
                table: "OrderItem",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_PrimaryClientEmployee_ClientEmployeeID",
                table: "PrimaryClientEmployee",
                column: "ClientEmployeeID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClientEmployeePrimaryAddress");

            migrationBuilder.DropTable(
                name: "ClientToEmployee");

            migrationBuilder.DropTable(
                name: "Communication");

            migrationBuilder.DropTable(
                name: "CSOEmployee");

            migrationBuilder.DropTable(
                name: "OrderItem");

            migrationBuilder.DropTable(
                name: "PrimaryClientEmployee");

            migrationBuilder.DropTable(
                name: "ClientEmployeeAddress");

            migrationBuilder.DropTable(
                name: "Conversation");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "ClientEmployee");

            migrationBuilder.DropTable(
                name: "InternalEmployee");

            migrationBuilder.DropTable(
                name: "Client");

            migrationBuilder.DropTable(
                name: "Address");
        }
    }
}
