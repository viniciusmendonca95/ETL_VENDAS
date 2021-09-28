namespace ETL_VENDAS.Models.Dimensional
{
    public class DmProdutos
    {
        public int Id { get; private set; }
        public string Classe { get; private set; }
        public string Descricao { get; private set; }

        public DmClientes(int id, string classe, string descricao)
        {
            this.Id = id;
            this.Classe = Classe;
            this.Descricao = Descricao;
        }
    }
}