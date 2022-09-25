using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MrktUsuario.Repository.Migrations
{
    public partial class CreateDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Cpf = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: false),
                    Senha = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sexo = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    Celular = table.Column<int>(type: "int", maxLength: 1, nullable: false),
                    Endereco = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pagamento",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NumeroCartao = table.Column<int>(type: "int", maxLength: 16, nullable: false),
                    NomeCartao = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FormaPagamento = table.Column<int>(type: "int", nullable: false),
                    Parcelas = table.Column<int>(type: "int", nullable: false),
                    ValorPago = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DataPagamento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    UsuarioId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pagamento", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pagamento_Usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pedido",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataAtualizacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ValorTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    UsuarioId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pedido", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pedido_Usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pagamento_UsuarioId",
                table: "Pagamento",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Pedido_UsuarioId",
                table: "Pedido",
                column: "UsuarioId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pagamento");

            migrationBuilder.DropTable(
                name: "Pedido");

            migrationBuilder.DropTable(
                name: "Usuario");
        }
    }
}
