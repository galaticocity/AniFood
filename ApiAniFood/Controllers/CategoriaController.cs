using System.Collections.Generic;
using ApiAniFood.Models.Class;
using ApiAniFood.Repository.Interfaces;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace ApiAniFood.Controllers {
    [Route ("anifood/[Controller]")]
    public class CategoriaController : Controller {
        private readonly ICategoriaRepository _categoriaRepositoy;

        public CategoriaController (ICategoriaRepository categoriaRepository) {
            _categoriaRepositoy = categoriaRepository;
        }

        [EnableCors ("MyPolicy")]
        [HttpGet ("{nome}", Name = "GetCategoria")]
        public IActionResult Find (string nome) {
            var categoria = _categoriaRepositoy.Find (nome);
            if (categoria == null)
                return NotFound ();
            return new ObjectResult (categoria);
        }

        [EnableCors ("MyPolicy")]
        [HttpGet ("{id}", Name = "GetCategoriaById")]
        public IActionResult Find (int id) {
            var categoria = _categoriaRepositoy.FindById (id);
            if (categoria == null)
                return NotFound ();
            return new ObjectResult (categoria);
        }

        [EnableCors ("MyPolicy")]
        [HttpGet]
        public IEnumerable<Categoria> GetAll () {
            return _categoriaRepositoy.GetAll ();
        }

        [EnableCors ("MyPolicy")]
        [HttpPost]
        public IActionResult Create ([FromBody] Categoria categoria) {
            if (categoria == null)
                return BadRequest ();
            _categoriaRepositoy.Add (categoria);
            return CreatedAtRoute ("GetCategoria", new Categoria { ID = categoria.ID }, categoria);
        }
    }
}