using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FirstMVC.Migrations
{
    /// <inheritdoc />
    public partial class Create_table_Customer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CusstomerID",
                table: "Customer",
                newName: "CustomerID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CustomerID",
                table: "Customer",
                newName: "CusstomerID");
        }
    }
}
