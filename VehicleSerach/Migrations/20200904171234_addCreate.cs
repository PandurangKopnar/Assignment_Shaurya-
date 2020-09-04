using Microsoft.EntityFrameworkCore.Migrations;

namespace VehicleSerach.Migrations
{
    public partial class addCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "id",
                keyValue: 1,
                column: "Vehicle_Number",
                value: "MH-11 SS-1234");

            migrationBuilder.InsertData(
                table: "vehicles",
                columns: new[] { "id", "Body_type", "Chassis_Number", "DeviceID", "Engine_Number", "Load_carrying_capacity", "Make_of_vehicle", "Manufacturing_year", "Model_Number", "Organisation_name", "UserID", "Vehicle_Number", "Vehicle_Type" },
                values: new object[,]
                {
                    { 2, "New", "13245", "345", "1234", "500000", "India", "2001", "345", "India", "1", "MH-12 SS-1234", "Car" },
                    { 3, "New", "13245", "345", "1234", "500000", "India", "2001", "345", "India", "1", "MH-13 SS-1234", "Car" },
                    { 4, "New", "13245", "345", "1234", "500000", "India", "2001", "345", "India", "1", "MH-14 SS-1234", "Car" },
                    { 5, "New", "13245", "345", "1234", "500000", "India", "2001", "345", "India", "1", "MH-15 SS-1234", "Car" },
                    { 6, "New", "13245", "345", "1234", "500000", "India", "2001", "345", "India", "1", "MH-16 SS-1234", "Car" },
                    { 7, "New", "13245", "345", "1234", "500000", "India", "2001", "345", "India", "1", "MH-17 SS-1234", "Car" },
                    { 8, "New", "13245", "345", "1234", "500000", "India", "2001", "345", "India", "1", "MH-18 SS-1234", "Car" },
                    { 9, "New", "13245", "345", "1234", "500000", "India", "2001", "345", "India", "1", "MH-19 SS-1234", "Car" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "id",
                keyValue: 1,
                column: "Vehicle_Number",
                value: "MH-12 SS-1234");
        }
    }
}
