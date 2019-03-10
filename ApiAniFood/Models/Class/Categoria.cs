using System;

namespace ApiAniFood.Models.Class {
    public class Categoria {
        public int ID { get; set; }
        public string Nome { get; set; }
        public char? StatusCategoria { get; set; }
        public DateTime? DataInsercao { get; set; }
        public DateTime? DataAtualizacao { get; set; }
    }
}