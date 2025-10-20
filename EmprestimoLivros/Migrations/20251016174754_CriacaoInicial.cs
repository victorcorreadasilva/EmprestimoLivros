﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmprestimoLivros.Migrations
{
    /// <inheritdoc />
    public partial class CriacaoInicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Emprestimo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Recebedor = table.Column<string>(type: "TEXT", nullable: false),
                    Fornecedor = table.Column<string>(type: "TEXT", nullable: false),
                    LivroEmprestado = table.Column<string>(type: "TEXT", nullable: false),
                    DataUltimaAtualizacao = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emprestimo", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Emprestimo");
        }
    }
}
