using ApiAniFood.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ApiAniFood.Controllers
{
    [Route("anifood/[Controller]")]
    public class LojaController
    {
        private readonly ILojaRepository _lojaRepository;
        public LojaController(ILojaRepository lojaRepository)
        {
            _lojaRepository = lojaRepository;
        }

        
    }
}