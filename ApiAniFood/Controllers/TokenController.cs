using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using ApiAniFood.Models.Class;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace ApiAniFood.Controllers {
    [Route ("anifood/[controller]")]
    public class TokenController : Controller {
        private readonly IConfiguration _configuration;
        public TokenController (IConfiguration configuration) {
            _configuration = configuration;
        }

        [AllowAnonymous]
        [HttpPost ("login")]
        public IActionResult RequestToken ([FromBody] Aluno oAluno) {
            //var aluno = 
            if (oAluno.Nome == "fsg" && oAluno.Senha == "fsg") {
                var claims = new [] {
                new Claim (ClaimTypes.Name, oAluno.Nome)
                };
            
                //armazena a chave de criptografia usada na criação do token
                var key = new SymmetricSecurityKey(
                    Encoding.UTF8.GetBytes(_configuration["SecurityKey"])
                );

                var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                var token = new JwtSecurityToken(
                    issuer: "anifood",
                    audience:"anifood",
                    claims: claims,
                    expires: DateTime.Now.AddMinutes(1440), //o token expira após 24 horas
                    signingCredentials: credentials
                );

                //se as credenciais forem válidas
                return Ok(new
                    {
                        token = new JwtSecurityTokenHandler().WriteToken(token)
                    }
                );
            }

            return BadRequest("Credenciais inválidas");

        }
    }
}