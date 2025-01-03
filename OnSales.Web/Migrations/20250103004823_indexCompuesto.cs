using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnSales.Web.Migrations
{
    /// <inheritdoc />
    public partial class indexCompuesto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Taxes_Name",
                table: "Taxes");

            migrationBuilder.CreateIndex(
                name: "IX_Statements_Name_CountryId",
                table: "Statements",
                columns: new[] { "Name", "CountryId" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Statements_Name_CountryId",
                table: "Statements");

            migrationBuilder.CreateIndex(
                name: "IX_Taxes_Name",
                table: "Taxes",
                column: "Name",
                unique: true);
        }
    }
}
