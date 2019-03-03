using System.Collections.Generic;
using ApiAlunos.Models;
using ApiAlunos.Repository;
using Microsoft.AspNetCore.Mvc;

namespace ApiAlunos.Controllers
{
    [Route("aluno/[Controller]")]
    public class AlunoController : Controller
    {
        private readonly IAlunoRepository _alunoRepository;
        public AlunoController(IAlunoRepository alunoRepository)
        {
            _alunoRepository = alunoRepository;
        }

        [HttpGet]
        public IEnumerable<Aluno> GetAll()
        {
            return _alunoRepository.GetAll();
        }

        [HttpGet("{ra}", Name="GetAluno")]
        public IActionResult GetByRa(string ra)
        {
            var aluno = _alunoRepository.Find(ra);
            if(aluno == null)
                return NotFound();
            return new ObjectResult(aluno);
        }
    }
}