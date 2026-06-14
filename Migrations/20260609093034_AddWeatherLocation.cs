using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DashboardProject.Migrations
{
    /// <inheritdoc />
    public partial class AddWeatherLocation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "WeatherLocations",
                type: "character varying(90)",
                maxLength: 90,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "CountryCode",
                table: "WeatherLocations",
                type: "character varying(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "WeatherLocations",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(90)",
                oldMaxLength: 90);

            migrationBuilder.AlterColumn<string>(
                name: "CountryCode",
                table: "WeatherLocations",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(10)",
                oldMaxLength: 10);
        }
    }
}
