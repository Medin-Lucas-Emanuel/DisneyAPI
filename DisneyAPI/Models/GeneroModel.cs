using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DisneyAPI.Models
{
    public class GeneroModel
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Nombre { get; set; }

        [Required]
        public string ImgUrl { get; set; }
        public List<PeliculaModel> Peliculas { get; set; }
    }
}
