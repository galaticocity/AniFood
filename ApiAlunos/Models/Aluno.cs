namespace ApiAlunos.Models
{
    public class Aluno
    {
        public int AlunoId { get; set; }       
        public string RA { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public string Instituicao { get; set; }
    }
}