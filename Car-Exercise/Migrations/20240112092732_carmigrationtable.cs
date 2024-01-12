using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Car_Exercise.Migrations
{
    /// <inheritdoc />
    public partial class carmigrationtable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "Brand", "Model", "Year" },
                values: new object[] { 3, "Volvo", "V40", 2020 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
