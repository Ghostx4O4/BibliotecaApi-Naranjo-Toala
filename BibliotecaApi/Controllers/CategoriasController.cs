using Microsoft.AspNetCore.Mvc;
using BibliotecaApi.Models;

namespace BibliotecaApi.Controllers {
    [ApiController]
    [Route("api/[controller]")]
    public class CategoriasController : ControllerBase {
        private static List<Categoria> categorias = new List<Categoria> {
            new Categoria { Id = 1, Nombre = "Novela" },
            new Categoria { Id = 2, Nombre = "Ciencia Ficción" },
            new Categoria { Id = 3, Nombre = "Historia" }
        };

        [HttpGet]
        public ActionResult<IEnumerable<Categoria>> Get() {
            return Ok(categorias);
        }
    }
}