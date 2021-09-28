namespace ETL_VENDAS.Models.Dimensional
{
    public class FtInadimplencia
    {
        public long IdTempo { get; private set; }
        public int IdCliente { get; private set; }
        public decimal TotalVendido { get; private set; }
        public decimal ValorParcelasAtrasadas { get; private set; }
        public int QntdParcelasVencidas { get; private set; }

        public FtInadimplencia(long idTempo, int idCliente, List<Vendas> vendas)
        {
            this.IdTempo = IdTempo;
            this.IdCliente = IdCliente;

            TotalVendido = CalcularTotalVendido(vendas)
            ValorParcelasAtrasadas = CalcularValorParcelasAtrasadas(vendas)
            QntdParcelasVencidas = CalcularQntdParcelasVencidas(vendas)

        }


        private decimal CalcularTotalVendido(List<Vendas> vendas)
        {
          return 
        }
        
        private decimal CalcularValorParcelasAtrasadas(List<Vendas> vendas)
        {
          return 
        }

        private decimal CalcularQntdParcelasVencidas(List<Vendas> vendas)
        {
          return 
        }
    }
}