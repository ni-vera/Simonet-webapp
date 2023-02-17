using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace webapp.Migrations
{
    /// <inheritdoc />
    public partial class InheriTry2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Propuestas");

            migrationBuilder.AddColumn<string>(
                name: "Colaborador",
                table: "Entradas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Entradas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Estado",
                table: "Entradas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Fecha",
                table: "Entradas",
                type: "datetime2",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Colaborador",
                table: "Entradas");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Entradas");

            migrationBuilder.DropColumn(
                name: "Estado",
                table: "Entradas");

            migrationBuilder.DropColumn(
                name: "Fecha",
                table: "Entradas");

            migrationBuilder.CreateTable(
                name: "Propuestas",
                columns: table => new
                {
                    entrada = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Colaborador = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    pagina = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Propuestas", x => x.entrada);
                });
        }
    }
}
