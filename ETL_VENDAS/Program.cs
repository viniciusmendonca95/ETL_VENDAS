using Oracle.ManagedDataAccess.Client;
using System;

namespace ETL_VENDAS
{
    class Program
    {
        static string _conexaoBancoOperacional = "Data Source=(DESCRIPTION =(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST = localhost)(PORT = 1521)))(CONNECT_DATA =(SERVICE_NAME = XE)));User ID=vendas;Password=vendas;";
        static string _conexaoBancoDimensional = "Data Source=(DESCRIPTION =(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST = localhost)(PORT = 1521)))(CONNECT_DATA =(SERVICE_NAME = XE)));User ID=dw_vendas;Password=dw_vendas;";
        static void Main(string[] args)
        {
            using var conexaoOperacional = new OracleConnection(_conexaoBancoOperacional);
            using var conexaoDimensional = new OracleConnection(_conexaoBancoDimensional);

            var extracao = new Extracao(conexaoOperacional);

            var trasformacao = new Transformacao(extracao);

            var carga = new Carga(trasformacao, conexaoDimensional);

            Console.WriteLine("Finalizado o ETL");

        }
    }
}
