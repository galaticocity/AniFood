using System.Collections.Generic;
using ApiAniFood.Models.Class;
using ApiAniFood.Repository.Interfaces;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace ApiAniFood.Controllers {
    [Route ("anifood/[Controller]")]
    public class ProdutoController {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoController (IProdutoRepository produtoRepository) {
            _produtoRepository = produtoRepository;
        }

        [EnableCors ("MyPolicy")]
        [HttpGet ("nome/{nome}", Name = "GetProdutoByName")]
        public IEnumerable<Produto> Find (string nome) {
            return _produtoRepository.Find (nome);
        }

        [EnableCors ("MyPolicy")]
        [HttpPost ("nome", Name = "PostProdutoByName")]
        public IEnumerable<Produto> FindPost([FromBody]Aluno Aluno) {
            return _produtoRepository.Find (Aluno.Nome);
        }

        [EnableCors("MyPolicy")]
        [HttpGet ("{id}", Name = "GetProdutoById")]
        public IActionResult FindByID (int id) {
            var produto = _produtoRepository.FindById (id);
            if (produto == null)
                return null;
            return new ObjectResult (produto);
        }

        [EnableCors("MyPolicy")]
        [HttpGet]
        public IEnumerable<Produto> GetAll () {
            return _produtoRepository.GetAll ();
        }

        [EnableCors("MyPolicy")]
        [HttpGet ("{id}/loja", Name = "GetProdutoByLanchoneteId")]
        public IEnumerable<Produto> ProdutoPorLanchoneteId (int id) {
            return _produtoRepository.FindProdutoByLanchoneteId (id);
        }

    }
}