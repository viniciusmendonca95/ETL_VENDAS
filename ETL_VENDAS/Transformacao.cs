using ETL_VENDAS.Models.Dimensional;
using ETL_VENDAS.Models.Operational;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;

namespace ETL_VENDAS
{
    public class Transformacao
    {
        public Transformacao(Extracao extracao)
        {
            public List<DmTempo> DmTempo { get; private set; } = new List<DmTempo>();
            public List<DmCliente> DmClientes { get; private set; } = new List<DmCliente>();
            public List<DmFornecedor> DmFornecedores { get; private set; } = new List<DmFornecedor>();
            public List<DmProduto> DmProdutos { get; private set; } = new List<DmProduto>();
            public List<DmTipoVenda> DmTipoVenda { get; private set; } = new List<DmTipoVenda>();
            public List<FtInadimplencia> FtInadimplencia { get; private set; } = new List<FtInadimplencia>();
            public List<FtVenda> FtVendas { get; private set; } = new List<FtVenda>();

        public Transformacao(Extracao extracao)
        {
            TransformarTempo(extracao.Tempo);
            TransformarClientes(extracao.Clientes);
            TransformarFornecedores(extracao.Fornecedores);
            TransformarProdutos(extracao.Produtos);
            TransformarTipoVenda(extracao.TipoVenda);
            TransformarFInadimplencia(extracao.Inadimplencia);
            TransformarVendas(extracao.Vendas);
        }

        private void TransformarTempo(DataTable data)
        {
            Console.WriteLine("Iniciando transformação do tempo");
            var sw = new Stopwatch();
            sw.Start();
            foreach (DataRow item in data.Rows)
            {
                DmTempo.Add(new DmTempo(Convert.ToDateTime(item.ItemArray[0])));
            }
            sw.Stop();

            Console.WriteLine($"Finalizando transformação do tempo" +
                              $" - Tempo de transformação: {sw.Elapsed.TotalSeconds} segundos.");

        }

        private void TransformarClientes(DataTable data)
        {
            Console.WriteLine("Iniciando transformação de clientes");
            var sw = new Stopwatch();
            sw.Start();
            foreach (DataRow item in data.Rows)
            {
                DmClientes.Add(new DmCliente(Convert.ToInt32(obj[0]), (string)obj[1],(string)obj[2], (string)obj[3]));
            }
            sw.Stop();

            Console.WriteLine($"Finalizando transformação de clientes" +
                              $" - Tempo de transformação: {sw.Elapsed.TotalSeconds} segundos.");

        }

        private void TransformarFornecedores(DataTable data)
        {
            Console.WriteLine("Iniciando transformação de fornecedores");
            var sw = new Stopwatch();
            sw.Start();
            foreach (DataRow item in data.Rows)
            {
                DmFornecedores.Add(new DmFornecedor(Convert.ToInt32(obj[0]), (string)obj[1],(string)obj[2], (string)obj[3]));
            }
            sw.Stop();

            Console.WriteLine($"Finalizando transformação de fornecedores" +
                              $" - Tempo de transformação: {sw.Elapsed.TotalSeconds} segundos.");

        }

        private void TransformarProdutos(DataTable data)
        {
            Console.WriteLine("Iniciando transformação de produtos");
            var sw = new Stopwatch();
            sw.Start();
            foreach (DataRow item in data.Rows)
            {
                DmProdutos.Add(new DmProduto(Convert.ToInt32(obj[0]), (string)obj[1],(string)obj[2]));
            }
            sw.Stop();

            Console.WriteLine($"Finalizando transformação de produtos" +
                              $" - Tempo de transformação: {sw.Elapsed.TotalSeconds} segundos.");

        }

        private void TransformarTipoVendas(DataTable data)
        {
            Console.WriteLine("Iniciando transformação de TipoVenda");
            var sw = new Stopwatch();
            sw.Start();
            foreach (DataRow item in data.Rows)
            {
                DmTipoVenda.Add(new DmTipoVenda(Convert.ToInt32(obj[0]), (string)obj[1]);
            }
            sw.Stop();

            Console.WriteLine($"Finalizando transformação de TipoVenda" +
                              $" - Tempo de transformação: {sw.Elapsed.TotalSeconds} segundos.");

        }

        }
    }
}
