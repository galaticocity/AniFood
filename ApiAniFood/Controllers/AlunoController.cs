using ApiAniFood.Models.Class;
using ApiAniFood.Repository.Interfaces;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ApiAniFood.Controllers {
    [Route ("aluno/[Controller]")]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class AlunoController : Controller {
        private readonly IAlunoRepository _alunoRepository;

        public AlunoController(IAlunoRepository alunoRepository)
        {
            _alunoRepository = alunoRepository;
        }

        [HttpPost ("login")]
        public IActionResult Login ([FromBody] Aluno oAluno) {
            var aluno = _alunoRepository.Login (oAluno.RA, oAluno.Senha);
            if (aluno == null)
                return BadRequest ();
            return new ObjectResult (aluno);
        }
    }

}