using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace webapp.Migrations
{
    /// <inheritdoc />
    public partial class PropuestasAñadidas2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Entrada",
                table: "Entrada");

            migrationBuilder.RenameTable(
                name: "Entrada",
                newName: "Entradas");

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

            migrationBuilder.AddPrimaryKey(
                name: "PK_Entradas",
                table: "Entradas",
                column: "entrada");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Entradas",
                table: "Entradas");

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

            migrationBuilder.RenameTable(
                name: "Entradas",
                newName: "Entrada");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Entrada",
                table: "Entrada",
                column: "entrada");
        }
    }
}
