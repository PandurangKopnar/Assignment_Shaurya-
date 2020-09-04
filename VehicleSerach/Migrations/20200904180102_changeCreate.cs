using Microsoft.EntityFrameworkCore.Migrations;

namespace VehicleSerach.Migrations
{
    public partial class changeCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "id",
                keyValue: 2,
                column: "Vehicle_Type",
                value: "Bus");

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "id",
                keyValue: 3,
                column: "Vehicle_Type",
                value: "Tempo");

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "id",
                keyValue: 4,
                column: "Vehicle_Type",
                value: "Truck");

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "id",
                keyValue: 5,
                column: "Vehicle_Type",
                value: "Bus");

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "id",
                keyValue: 7,
                column: "Vehicle_Type",
                value: "Bus");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "id",
                keyValue: 2,
                column: "Vehicle_Type",
                value: "Car");

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "id",
                keyValue: 3,
                column: "Vehicle_Type",
                value: "Car");

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "id",
                keyValue: 4,
                column: "Vehicle_Type",
                value: "Car");

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "id",
                keyValue: 5,
                column: "Vehicle_Type",
                value: "Car");

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "id",
                keyValue: 7,
                column: "Vehicle_Type",
                value: "Car");
        }
    }
}
