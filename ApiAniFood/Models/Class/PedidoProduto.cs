using System;

namespace ApiAniFood.Models.Class {
    public class PedidoProduto {
        public int ID { get; set; }
        public int IdProduto { get; set; }
        public int IdPedido { get; set; }
        public int Qtd { get; set; }
        public char StatusPedidoProduto { get; set; }
        public DateTime DataInsercao { get; set; }
        public DateTime DataAtualizacao { get; set; }
    }
}