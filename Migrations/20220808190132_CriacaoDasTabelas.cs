using Microsoft.EntityFrameworkCore.Migrations;

namespace Movies.Migrations
{
    public partial class CriacaoDasTabelas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    CategoriaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    ImagemUrl = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.CategoriaId);
                });

            migrationBuilder.CreateTable(
                name: "Filmes",
                columns: table => new
                {
                    FilmeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: false),
                    ImagemUrl = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Diretor = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true),
                    Atores = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Ano = table.Column<int>(type: "int", nullable: false),
                    Duracao = table.Column<int>(type: "int", nullable: false),
                    FaixaEtaria = table.Column<int>(type: "int", nullable: false),
                    ClassificacaoEstrela = table.Column<int>(type: "int", nullable: false),
                    CategoriaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Filmes", x => x.FilmeId);
                    table.ForeignKey(
                        name: "FK_Filmes_Categorias_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "Categorias",
                        principalColumn: "CategoriaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Filmes_CategoriaId",
                table: "Filmes",
                column: "CategoriaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Filmes");

            migrationBuilder.DropTable(
                name: "Categorias");
        }
    }
}
