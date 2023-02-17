using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace webapp.Migrations
{
    /// <inheritdoc />
    public partial class PropuestasAñadidas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Entradas",
                table: "Entradas");

            migrationBuilder.RenameTable(
                name: "Entradas",
                newName: "Entrada");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Entrada",
                table: "Entrada",
                column: "entrada");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Entrada",
                table: "Entrada");

            migrationBuilder.RenameTable(
                name: "Entrada",
                newName: "Entradas");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Entradas",
                table: "Entradas",
                column: "entrada");
        }
    }
}
