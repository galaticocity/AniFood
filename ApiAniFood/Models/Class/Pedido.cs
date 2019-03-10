using System;

namespace ApiAniFood.Models.Class {
    public class Pedido {
        public int ID { get; set; }
        public int IdAluno { get; set; }
        public char? StatusPedido { get; set; }
        public DateTime? DataInsercao { get; set; }
        public DateTime? DataAtualizacao { get; set; }
        public DateTime? DataFinalizacao { get; set; }
    }
}