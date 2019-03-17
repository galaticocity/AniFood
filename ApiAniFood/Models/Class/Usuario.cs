using System;

namespace ApiAniFood.Models.Class {
    public class Usuario {
        public int ID { get; set; }
        public int IdLoja { get; set; }
        public string Nome { get; set; }
        public char? StatusUsuario { get; set; }
        public string Senha { get; set; }
        public DateTime? DataInsercao { get; set; }
        public DateTime? DataAtualizacao { get; set; }
    }
}