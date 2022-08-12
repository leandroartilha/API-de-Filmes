using Microsoft.EntityFrameworkCore.Migrations;

namespace Movies.Migrations
{
    public partial class PopularCategorias : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Insert into Categorias(Nome,ImagemUrl) Values('Ação', 'acao.jpg')");
            migrationBuilder.Sql("Insert into Categorias(Nome,ImagemUrl) Values('Aventura', 'aventura.jpg')");
            migrationBuilder.Sql("Insert into Categorias(Nome,ImagemUrl) Values('Comédia', 'Comedia.jpg')");
            migrationBuilder.Sql("Insert into Categorias(Nome,ImagemUrl) Values('Drama', 'drama.jpg')");
            migrationBuilder.Sql("Insert into Categorias(Nome,ImagemUrl) Values('Infantil', 'infantil.jpg')");
            migrationBuilder.Sql("Insert into Categorias(Nome,ImagemUrl) Values('Terror', 'Terror.jpg')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Delete from Categorias");
        }
    }
}

