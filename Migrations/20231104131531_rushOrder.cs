using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MegaDesk_2._0.Migrations
{
    /// <inheritdoc />
    public partial class rushOrder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "surface",
                table: "Desks");

            migrationBuilder.AddColumn<int>(
                name: "rushOrder",
                table: "Desks",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "rushOrder",
                table: "Desks");

            migrationBuilder.AddColumn<int>(
                name: "surface",
                table: "Desks",
                type: "int",
                nullable: true);
        }
    }
}
