using System.Collections.Generic;
using ApiAniFood.Models.Class;
using ApiAniFood.Repository.Interfaces;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace ApiAniFood.Controllers {
    [Route ("anifood/[Controller]")]
    public class LojaController {
        private readonly ILojaRepository _lojaRepository;
        public LojaController (ILojaRepository lojaRepository) {
            _lojaRepository = lojaRepository;
        }

        [EnableCors ("MyPolicy")]
        [HttpPost ("nome", Name="PostLojaName")]
        public IEnumerable<Loja> FindByName ([FromBody] Loja loja) {
            return _lojaRepository.FindByName (loja.Nome);
        }

        [EnableCors("MyPolicy")]
        [HttpGet]
        public IEnumerable<Loja> GetAll(){
            return _lojaRepository.GetAll();
        }

    }
}