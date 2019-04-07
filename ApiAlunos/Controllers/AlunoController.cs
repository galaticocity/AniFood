using System.Collections.Generic;
using ApiAlunos.Models;
using ApiAlunos.Repository;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace ApiAlunos.Controllers {
    [Route ("apialuno/[Controller]")]
    public class AlunoController : Controller {
        private readonly IAlunoRepository _alunoRepository;
        public AlunoController (IAlunoRepository alunoRepository) {
            _alunoRepository = alunoRepository;
        }

        [EnableCors("MyPolicy")]
        [HttpGet]
        public IEnumerable<Aluno> GetAll () {
            return _alunoRepository.GetAll ();
        }

        [EnableCors("MyPolicy")]
        [HttpGet ("ra/{ra}", Name = "GetAluno")]
        public IActionResult GetByRa (string ra) {
            var aluno = _alunoRepository.Find (ra);
            if (aluno == null)
                return NotFound ();
            return new ObjectResult (aluno);
        }

        [EnableCors("MyPolicy")]
        [HttpPost ("login")]
        public IActionResult Login ([FromBody] Aluno pAluno) {
            var aluno = _alunoRepository.Login (pAluno.RA, pAluno.Senha);
            if (aluno == null)
                return BadRequest ();
            return new ObjectResult (aluno);
        }
    }
}