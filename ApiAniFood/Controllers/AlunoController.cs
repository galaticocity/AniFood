using ApiAniFood.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ApiAniFood.Controllers
{
    [Route("aluno/[Controller]")]
    public class AlunoController : Controller
    {
        private readonly IAlunoRepository _alunoRepository;
    }
}