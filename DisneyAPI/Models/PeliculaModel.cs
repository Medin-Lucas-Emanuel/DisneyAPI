using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DisneyAPI.Models
{
    public class PeliculaModel
    {
        public int Id { get; set; }
        [Required]
        public string ImgUrl { get; set; }
        [Required, MinLength(5)]
        public string Titulo { get; set; }
        [Required]
        public DateTime FechaCreacion { get; set; }
        [Required, Range(1,5)]
        public int calificacion { get; set; }
        public List<PersonajeModel> Personajes { get; set; }
        public List<GeneroModel> Generos { get; set; }
    }
}
