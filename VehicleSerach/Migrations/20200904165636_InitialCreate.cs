using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VehicleSerach.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "vehicles",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Vehicle_Number = table.Column<string>(nullable: true),
                    Vehicle_Type = table.Column<string>(nullable: true),
                    Chassis_Number = table.Column<string>(nullable: true),
                    Engine_Number = table.Column<string>(nullable: true),
                    Manufacturing_year = table.Column<string>(nullable: true),
                    Load_carrying_capacity = table.Column<string>(nullable: true),
                    Make_of_vehicle = table.Column<string>(nullable: true),
                    Model_Number = table.Column<string>(nullable: true),
                    Body_type = table.Column<string>(nullable: true),
                    Organisation_name = table.Column<string>(nullable: true),
                    DeviceID = table.Column<string>(nullable: true),
                    UserID = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vehicles", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "vehicles",
                columns: new[] { "id", "Body_type", "Chassis_Number", "DeviceID", "Engine_Number", "Load_carrying_capacity", "Make_of_vehicle", "Manufacturing_year", "Model_Number", "Organisation_name", "UserID", "Vehicle_Number", "Vehicle_Type" },
                values: new object[] { 1, "New", "13245", "345", "1234", "500000", "India", "2001", "345", "India", "1", "MH-12 SS-1234", "Car" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "vehicles");
        }
    }
}
