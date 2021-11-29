using DisneyAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DisneyAPI
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }

        public DbSet<GeneroModel> Generos { get; set; }
        public DbSet<PeliculaModel> Peliculas { get; set; }
        public DbSet<PersonajeModel> Personajes { get; set; }
    }
}
