using Microsoft.EntityFrameworkCore.Migrations;

namespace Movies.Migrations
{
    public partial class PopularFilmes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Insert into Filmes(Nome,Descricao,ImagemUrl,Diretor,Atores,Ano,Duracao,FaixaEtaria,ClassificacaoEstrela,CategoriaId)" +
                " Values('Panico', 'Filme assustador de um cara de mascara','imagemPanico','Wes Craven','Jim Carrey',2020,100,16,4,6)");

            migrationBuilder.Sql("Insert into Filmes(Nome,Descricao,ImagemUrl,Diretor,Atores,Ano,Duracao,FaixaEtaria,ClassificacaoEstrela,CategoriaId)" +
                " Values('As Branquelas', 'Dois homens policiais vestidos de mulher','imagemBranq','Waynes','Irmaos Waynes',2005,90,14,5,3)");

            migrationBuilder.Sql("Insert into Filmes(Nome,Descricao,ImagemUrl,Diretor,Atores,Ano,Duracao,FaixaEtaria,ClassificacaoEstrela,CategoriaId)" +
                " Values('Indiana Jones', 'Muita aventura','imagemJones','Diretor Jones','Harrison Ford',2010,120,12,5,2)");

            migrationBuilder.Sql("Insert into Filmes(Nome,Descricao,ImagemUrl,Diretor,Atores,Ano,Duracao,FaixaEtaria,ClassificacaoEstrela,CategoriaId)" +
                " Values('Croods', 'Homens das cavernas','imagemCavernas','Flinston','Croodzao',2017,85,0,3,5)");

            migrationBuilder.Sql("Insert into Filmes(Nome,Descricao,ImagemUrl,Diretor,Atores,Ano,Duracao,FaixaEtaria,ClassificacaoEstrela,CategoriaId)" +
                " Values('Missao Impossivel', 'Muita ação','imagemImpossivel','DiretorImpossivel','Tom Cruise',2015,130,12,5,1)");

            migrationBuilder.Sql("Insert into Filmes(Nome,Descricao,ImagemUrl,Diretor,Atores,Ano,Duracao,FaixaEtaria,ClassificacaoEstrela,CategoriaId)" +
                " Values('A Vida é Bela', 'Filme sobre nazistas e judeus','imagemDrama','Director Italiano','Roberto Benigni',1997,140,14,5,4)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Delete from Filmes");
        }
    }
}