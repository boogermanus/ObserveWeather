using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ObserveWeather.Blazor.Migrations
{
    /// <inheritdoc />
    public partial class UserStation_DisplayName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DisplayName",
                table: "UserStations",
                type: "TEXT",
                maxLength: 200,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DisplayName",
                table: "UserStations");
        }
    }
}
