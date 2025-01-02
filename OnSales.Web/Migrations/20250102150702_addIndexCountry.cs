using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnSales.Web.Migrations
{
    /// <inheritdoc />
    public partial class addIndexCountry : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Countries_NameCountry",
                table: "Countries",
                column: "NameCountry",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Countries_NameCountry",
                table: "Countries");
        }
    }
}
