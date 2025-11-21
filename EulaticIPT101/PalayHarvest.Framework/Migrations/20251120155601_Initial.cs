using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PalayHarvest.Framework.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HarvestQuantity",
                table: "Farmers");

            migrationBuilder.AddColumn<int>(
                name: "HarvestQty",
                table: "Farmers",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HarvestQty",
                table: "Farmers");

            migrationBuilder.AddColumn<double>(
                name: "HarvestQuantity",
                table: "Farmers",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
