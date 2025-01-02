using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnSales.Web.Migrations
{
    /// <inheritdoc />
    public partial class addTableIndiceTaxesType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_TaxeTypes_NameTaxesType",
                table: "TaxeTypes",
                column: "NameTaxesType",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_TaxeTypes_NameTaxesType",
                table: "TaxeTypes");
        }
    }
}
