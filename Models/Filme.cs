using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Movies.Models
{
    [Table("Filmes")]
    public class Filme
    {
        [Key]
        public int FilmeId { get; set; }

        [Required]
        [StringLength(80)]
        public string Nome { get; set; }

        [Required]
        [StringLength(400)]
        public string Descricao { get; set; }

        [Required]
        [StringLength(300)]
        public string ImagemUrl { get; set; }

        [StringLength(80)]
        public string Diretor { get; set; }

        [StringLength(200)]
        public string Atores { get; set; }
        
        [Required]
        public int Ano { get; set; }

        public int Duracao { get; set; }

        public int FaixaEtaria { get; set; }

        public int ClassificacaoEstrela { get; set; }
      
        public int CategoriaId { get; set; }
       
        [JsonIgnore]
        public Categoria Categoria { get; set; }


    }
}
