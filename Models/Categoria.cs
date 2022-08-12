using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Movies.Models
{
    [Table("Categorias")]
    public class Categoria
    {
        public Categoria()
        {
            Filmes = new Collection<Filme>();
        }
        [Key]
        public int CategoriaId { get; set; }

        [Required]
        [StringLength(80)]
        public string Nome { get; set; }

        [Required]
        [StringLength(400)]
        public string ImagemUrl { get; set; }
        public ICollection<Filme> Filmes { get; set; }

    }
}
