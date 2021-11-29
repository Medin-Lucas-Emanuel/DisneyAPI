using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DisneyAPI.Models;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DisneyAPI.Controllers
{
    [Route("characters")]
    [ApiController]
    public class PersonajeController : ControllerBase
    {
        private DatabaseContext _context { get; }

        public PersonajeController(DatabaseContext context)
        {
            _context = context;
        }
       
        [HttpGet("")]
        public async Task<IActionResult> GetAll()
        {
            var personajes = await _context.Personajes.Select(x => new PersonajeModel()
            {
                Nombre = x.Nombre,
                ImgUrl = x.ImgUrl
            }
            ).ToListAsync();
            return Ok(personajes);
        }

        // GET api/<PersonajeController>/5
        [HttpGet("{id}")]
        public string GetPersonajeById(int id)
        {
            return "value";
        }


        [HttpPost("")]
        public async Task<IActionResult> AddNewPersonaje([FromBody] PersonajeModel personaje)
        {
            _context.Personajes.Add(personaje);
           await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetPersonajeById), new { id = personaje.Id, controller = "Personaje" }, personaje.Id);
        }

        // PUT api/<PersonajeController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }


        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeletePersonaje([FromRoute] int id)
        {
            var personaje = new PersonajeModel() { Id = id };

            _context.Personajes.Remove(personaje);
            await _context.SaveChangesAsync();

            return Ok();
        }
    }
}
