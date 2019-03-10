using System;

namespace ApiAniFood.Models.Class {
    public class Produto {
        public int ID { get; set; }
        public int IdCategoria { get; set; }
        public string Nome { get; set; }
        public double Valor { get; set; }
        public char? StatusProduto { get; set; }
        public DateTime? DataInsercao { get; set; }
        public DateTime? DataAtualizacao { get; set; }
    }
}