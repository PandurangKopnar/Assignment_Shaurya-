using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace App1.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Mobile_Number = table.Column<string>(nullable: true),
                    Organization = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Email_address = table.Column<string>(nullable: true),
                    Location = table.Column<string>(nullable: true),
                    Photopath = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserID);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserID", "Address", "Email_address", "Location", "Mobile_Number", "Name", "Organization", "Photopath" },
                values: new object[] { 1, "Pune", "pandurang.kopnar7@gmail.com", "Pune", "8422910044", "Pandurang Kopnar", "-", "-" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
