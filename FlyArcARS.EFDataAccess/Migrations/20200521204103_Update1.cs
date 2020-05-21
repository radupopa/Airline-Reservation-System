using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FlyArcARS.EFDataAccess.Migrations
{
    public partial class Update1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Passenger_Administrator_AdministratorId",
                table: "Passenger");

            migrationBuilder.DropIndex(
                name: "IX_Passenger_AdministratorId",
                table: "Passenger");

            migrationBuilder.DropColumn(
                name: "AdministratorId",
                table: "Passenger");

            migrationBuilder.AlterColumn<int>(
                name: "Price",
                table: "Ticket",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AddColumn<int>(
                name: "Price",
                table: "Flight",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<Guid>(
                name: "AdministratorId",
                table: "Customer",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "Customer",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customer_Administrator_AdministratorId",
                table: "Customer");

            migrationBuilder.DropIndex(
                name: "IX_Customer_AdministratorId",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Flight");

            migrationBuilder.DropColumn(
                name: "AdministratorId",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Customer");

            migrationBuilder.AlterColumn<double>(
                name: "Price",
                table: "Ticket",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<Guid>(
                name: "AdministratorId",
                table: "Passenger",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Passenger_AdministratorId",
                table: "Passenger",
                column: "AdministratorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Passenger_Administrator_AdministratorId",
                table: "Passenger",
                column: "AdministratorId",
                principalTable: "Administrator",
                principalColumn: "AdministratorId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
