using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VendasDiladyAPI.Models
{
    public class Vendas
    {
        public string NomeCliente { get; set; }
        public string DataPedido { get; set; }
        public int FormaPagamento { get; set; }
        public int CodProduto { get; set; }
        public string DescricaoProduto { get; set; }
        public int Quantidade { get; set; }

        public Vendas(string nome, string data, int formaPagamento, int codProduto, string descricao, int quantidade)
        {
            this.NomeCliente = nome;
            this.DataPedido = data;
            this.FormaPagamento = formaPagamento;
            this.CodProduto = codProduto;
            this.DescricaoProduto = descricao;
            this.Quantidade = quantidade;
        }
    }
}