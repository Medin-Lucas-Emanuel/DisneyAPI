using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DisneyAPI.Models
{
    public class PersonajeModel
    {
        public int Id { get; set; }
        public string ImgUrl { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public decimal Peso { get; set; }
        public string Historia { get; set; }
        public List<PeliculaModel> Peliculas { get; set; }
    }
}
