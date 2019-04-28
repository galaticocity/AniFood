using System;

namespace ApiAniFood.Models.Class {
    public class Loja {
        public int ID { get; set; }
        public int IdInstiuicao { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Campus { get; set; }
        public char StatusLoja { get; set; }
        public DateTime? DataInsercao { get; set; }
        public DateTime? DataAtualizacao { get; set; }
    }
}