using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TalentHub.DAL.Migrations
{
    /// <inheritdoc />
    public partial class NovosCamposVaga : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Escopo",
                table: "Vagas",
                newName: "EscopoVaga");

            migrationBuilder.AddColumn<string>(
                name: "Cargo",
                table: "Vagas",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "DataExpiracao",
                table: "Vagas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<decimal>(
                name: "Salario",
                table: "Vagas",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cargo",
                table: "Vagas");

            migrationBuilder.DropColumn(
                name: "DataExpiracao",
                table: "Vagas");

            migrationBuilder.DropColumn(
                name: "Salario",
                table: "Vagas");

            migrationBuilder.RenameColumn(
                name: "EscopoVaga",
                table: "Vagas",
                newName: "Escopo");
        }
    }
}
