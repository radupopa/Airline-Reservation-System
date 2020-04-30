using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FlyArcARS.EFDataAccess.Migrations
{
    public partial class Create3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customer_Administrator_AdministratorId",
                table: "Customer");

            migrationBuilder.DropForeignKey(
                name: "FK_Ticket_Customer_CustomerId",
                table: "Ticket");

            migrationBuilder.DropIndex(
                name: "IX_Customer_AdministratorId",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "AdministratorId",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "Age",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Customer");

            migrationBuilder.RenameColumn(
                name: "CustomerLastName",
                table: "Ticket",
                newName: "PassengerLastName");

            migrationBuilder.RenameColumn(
                name: "CustomerId",
                table: "Ticket",
                newName: "PassengerId");

            migrationBuilder.RenameColumn(
                name: "CustomerFirstName",
                table: "Ticket",
                newName: "PassengerFirstName");

            migrationBuilder.RenameIndex(
                name: "IX_Ticket_CustomerId",
                table: "Ticket",
                newName: "IX_Ticket_PassengerId");

            migrationBuilder.RenameColumn(
                name: "Mail",
                table: "Customer",
                newName: "UserName");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Customer",
                newName: "Password");

            migrationBuilder.CreateTable(
                name: "Passenger",
                columns: table => new
                {
                    PassengerId = table.Column<Guid>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Mail = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    Age = table.Column<int>(nullable: false),
                    AdministratorId = table.Column<Guid>(nullable: true),
                    CustomerId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Passenger", x => x.PassengerId);
                    table.ForeignKey(
                        name: "FK_Passenger_Administrator_AdministratorId",
                        column: x => x.AdministratorId,
                        principalTable: "Administrator",
                        principalColumn: "AdministratorId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Passenger_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Passenger_AdministratorId",
                table: "Passenger",
                column: "AdministratorId");

            migrationBuilder.CreateIndex(
                name: "IX_Passenger_CustomerId",
                table: "Passenger",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ticket_Passenger_PassengerId",
                table: "Ticket",
                column: "PassengerId",
                principalTable: "Passenger",
                principalColumn: "PassengerId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ticket_Passenger_PassengerId",
                table: "Ticket");

            migrationBuilder.DropTable(
                name: "Passenger");

            migrationBuilder.RenameColumn(
                name: "PassengerLastName",
                table: "Ticket",
                newName: "CustomerLastName");

            migrationBuilder.RenameColumn(
                name: "PassengerId",
                table: "Ticket",
                newName: "CustomerId");

            migrationBuilder.RenameColumn(
                name: "PassengerFirstName",
                table: "Ticket",
                newName: "CustomerFirstName");

            migrationBuilder.RenameIndex(
                name: "IX_Ticket_PassengerId",
                table: "Ticket",
                newName: "IX_Ticket_CustomerId");

            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "Customer",
                newName: "Mail");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "Customer",
                newName: "LastName");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Customer",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "AdministratorId",
                table: "Customer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "Customer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Customer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Customer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Customer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Customer_AdministratorId",
                table: "Customer",
                column: "AdministratorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customer_Administrator_AdministratorId",
                table: "Customer",
                column: "AdministratorId",
                principalTable: "Administrator",
                principalColumn: "AdministratorId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Ticket_Customer_CustomerId",
                table: "Ticket",
                column: "CustomerId",
                principalTable: "Customer",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
