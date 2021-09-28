namespace ETL_VENDAS.Models.Dimensional
{
    public class DmFornecedores
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string Uf { get; private set; }
        public string Cidade { get; private set; }

        public DmClientes(int id, string nome, string uf, string cidade)
        {
            this.Id = id;
            this.Nome = Nome;
            this.Uf = Uf;
            this.Cidade = Cidade;
        }
    }
}