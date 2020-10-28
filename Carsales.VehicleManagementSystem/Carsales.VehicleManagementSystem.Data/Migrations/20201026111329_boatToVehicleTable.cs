using Microsoft.EntityFrameworkCore.Migrations;

namespace Carsales.VehicleManagementSystem.Data.Migrations
{
    public partial class boatToVehicleTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Length",
                table: "Vehicle",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Vehicle",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Length",
                table: "Vehicle");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Vehicle");
        }
    }
}
