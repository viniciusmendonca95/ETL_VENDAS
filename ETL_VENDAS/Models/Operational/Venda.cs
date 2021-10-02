using System;

namespace ETL_VENDAS.Models.Operational
{
    public class Venda
    {
        public int IdFornecedor { get; set; }
        public int IdProduto { get; set; }
        public int IdTipoVenda { get; set; }
        public decimal ValorVendido { get; set; }
        public bool StPagamento { get; set; }

    }
}