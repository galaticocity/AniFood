using System.Collections.Generic;
using ApiAniFood.Models.Class;
using ApiAniFood.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ApiAniFood.Controllers
{
    [Route("anifood/[Controller]")]
    public class ProdutoController
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoController(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        } 

        [HttpGet("{nome}",Name="GetProdutoByName")]
        public IEnumerable<Produto> Find(string nome)
        {
            return _produtoRepository.Find(nome);           
        }

        [HttpGet]
        public IEnumerable<Produto> GetAll()
        {
            return _produtoRepository.GetAll();
        }   
    }
}