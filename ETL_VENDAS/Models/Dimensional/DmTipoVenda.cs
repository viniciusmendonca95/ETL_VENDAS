namespace ETL_VENDAS.Models.Dimensional
{
    public class DmTipoVenda
    {
        public int Id { get; private set; }
        public string Tipo { get; private set; }

        public DmTipoVenda(int id, string tipo)
        {
            this.Id = id;
            this.Tipo = Tipo;
        }
    }
}