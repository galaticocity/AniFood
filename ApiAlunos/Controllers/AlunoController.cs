using System.Collections.Generic;
using ApiAlunos.Models;
using ApiAlunos.Repository;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace ApiAlunos.Controllers
{
    [Route("apialuno/[Controller]")]
    public class AlunoController : Controller
    {
        private readonly IAlunoRepository _alunoRepository;
        public AlunoController(IAlunoRepository alunoRepository)
        {
            _alunoRepository = alunoRepository;
        }
        
        [HttpGet]
        [EnableCors]
        public IActionResult Teste(){
            return StatusCode(200);
        }

        /*
        [HttpGet]
        public IEnumerable<Aluno> GetAll()
        {
            return _alunoRepository.GetAll();
        }

        [HttpGet("ra/{ra}", Name="GetAluno")]
        public IActionResult GetByRa(string ra)
        {
            var aluno = _alunoRepository.Find(ra);
            if(aluno == null)
                return NotFound();
            return new ObjectResult(aluno);
        }
        */

       [HttpPost("login")]
       public IActionResult Login([FromBody] Aluno oAluno)
       {
           var aluno = _alunoRepository.Login(oAluno.RA, oAluno.Senha, oAluno.Instituicao);
           if(aluno == null)
                return BadRequest();
            return new ObjectResult(aluno);
       }
    }
}