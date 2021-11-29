using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DisneyAPI.Models
{
    public class PersonajeModel
    {
        
        public int Id { get; set; }
        [Required]
        public string ImgUrl { get; set; }
        [Required, MaxLength(50)]
        public string Nombre { get; set; }
        [Required, Range(1,int.MaxValue)]
        public int Edad { get; set; }
        [Required, Range(0, double.MaxValue)]
        public double Peso { get; set; }
        [Required]
        public string Historia { get; set; }
        public List<PeliculaModel> Peliculas { get; set; }
    }
}
