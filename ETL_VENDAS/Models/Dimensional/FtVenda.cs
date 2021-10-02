namespace ETL_VENDAS.Models.Dimensional
{
    public class FtVenda
    {
        public long IdTempo { get; private set; }
        public int IdFornecedor { get; private set; }
        public int IdProduto { get; private set; }
        public int IdTipoVenda { get; private set; }
        public decimal TotalVendido { get; private set; }

        public FtVenda(long idTempo, int idFornecedor, int idProduto, int idTipoVenda List<Vendas> vendas)
        {
            this.IdTempo = IdTempo;
            this.IdFornecedor = IdFornecedor;
            this.IdProduto = IdProduto;
            this.IdTipoVenda =TipoVendador;
            
            TotalVendido = CalcularTotalVendido(vendas)
        }

        private decimal CalcularTotalVendido(List<Vendas> vendas)
        {
          return 
        }
    }
}