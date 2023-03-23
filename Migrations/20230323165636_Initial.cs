using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PruebaTecnica.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Operaciones",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ContactoBodega = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DireccionBodega = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaRetiro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NumeroContenedor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PesoContenedor = table.Column<int>(type: "int", nullable: false),
                    VolumenCarga = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Operaciones", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Carga",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    NumeroCarga = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ValorCarga = table.Column<double>(type: "float", nullable: false),
                    OperacionId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carga", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Carga_Operaciones_OperacionId",
                        column: x => x.OperacionId,
                        principalTable: "Operaciones",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Carga_OperacionId",
                table: "Carga",
                column: "OperacionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Carga");

            migrationBuilder.DropTable(
                name: "Operaciones");
        }
    }
}
