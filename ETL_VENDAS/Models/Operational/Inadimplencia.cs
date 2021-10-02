using System;

namespace ETL_VENDAS.Models.Operational
{
    public class Inadimplencia
    {
        public int IdCliente { get; set; }
        public decimal DataVencimentoParcelas { get; set; }
        public decimal ValorVendido { get; set; }
        public bool StPagamento { get; set; }
        public bool StParcela { get; set; }

    }
}