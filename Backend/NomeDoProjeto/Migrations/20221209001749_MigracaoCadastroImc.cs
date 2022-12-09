using Microsoft.EntityFrameworkCore.Migrations;

namespace NomeDoProjeto.Migrations
{
    public partial class MigracaoCadastroImc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Imcs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    altura = table.Column<double>(type: "REAL", nullable: false),
                    peso = table.Column<double>(type: "REAL", nullable: false),
                    imc = table.Column<double>(type: "REAL", nullable: false),
                    classificacao = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Imcs", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Imcs");
        }
    }
}
