using System;

namespace ApiAniFood.Models.Class
{
    public class Aluno
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public DateTime? DataNascimento { get; set; }
        public string RA { get; set; }
        public char StatusAluno { get; set; }
        public string Senha { get; set; }
        public DateTime? DataInsercao { get; set; }
        public DateTime? DataAtualizacao { get; set; }
    }
}