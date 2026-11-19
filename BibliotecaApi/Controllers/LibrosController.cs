using Microsoft.AspNetCore.Mvc;
using BibliotecaApi.Models;

namespace BibliotecaApi.Controllers
{
    [Route("api/[controller]")]
    public class LibrosController : ControllerBase
    {
        private static List<Libro> libros = new List<Libro>
        {
            new Libro { Id = 1, Titulo = "Cien Años de Soledad", Autor = "Gabriel García Márquez", Disponible = true },
            new Libro { Id = 2, Titulo = "Don Quijote de la Mancha", Autor = "Miguel de Cervantes", Disponible = false },
            new Libro { Id = 3, Titulo = "La Sombra del Viento", Autor = "Carlos Ruiz Zafón", Disponible = true }
        };
        [HttpGet]
        public ActionResult<IEnumerable<Libro>> Get()
        {
            return Ok(libros);
        }
        [HttpGet("{id}")]
        public ActionResult<Libro> Get(int id)
        {
            var libro = libros.FirstOrDefault(l => l.Id == id);
            if (libro == null)
            {
                return NotFound();
            }
            return Ok(libro);
        }
        [HttpPost]
        public ActionResult<Libro> Post([FromBody] Libro nuevoLibro)
        {
            nuevoLibro.Id = libros.Count + 1;
            libros.Add(nuevoLibro);

            return Created("", nuevoLibro);
        }
    }
}