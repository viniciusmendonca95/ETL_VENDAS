using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Diagnostics;

namespace ETL_VENDAS
{
    public class Extracao
    {
        public DataTable Tempo { get; private set; } = new DataTable();
        public DataTable Clientes { get; private set; } = new DataTable();
        public DataTable Produtos { get; private set; } = new DataTable();
        public DataTable Fornecedores { get; private set; } = new DataTable();
        public DataTable TipoVenda { get; private set; } = new DataTable();
        public DataTable Vendas { get; private set; } = new DataTable();
        public DataTable Inadimplencia { get; private set; } = new DataTable();

        public Extracao(OracleConnection connection)
        {
            try
            {
                ExtrairTempo(connection);
                ExtrairClientes(connection);
                ExtrairProdutos(connection);
                ExtrairFornecedores(connection);
                ExtrairTipoVenda(connection);
                ExtrairVendas(connection);
                ExtrairInadimplencia(connection);
            }
            finally
            {
                connection?.Clone();
            }

        private void ExtrairTempo(OracleConnection connection)
        {
            Console.WriteLine("Iniciando extração do Tempo");
            var sw = new Stopwatch();
            sw.Start();
            connection.Open();

            OracleCommand commandSQL = connection.CreateCommand();

            commandSQL.CommandText = @"SELECT DISTINCT L.DAT_LOC
                                              FROM LOCACOES L";

            commandSQL.CommandType = CommandType.Text;

            OracleDataReader dr = commandSQL.ExecuteReader();

            Tempo.Load(dr);
            connection.Close();
            sw.Stop();

            Console.WriteLine($"Finalizando extração do Tempo" +
                              $" - Total extraido: {Tempo.Rows.Count}" +
                              $" - Tempo de extração: {sw.Elapsed.TotalSeconds} segundos.");

        }

        }
    }
}
