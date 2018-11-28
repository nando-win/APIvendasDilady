using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using VendasDiladyAPI.Models;

namespace VendasDiladyAPI.Controllers
{
    public class VendasController : ApiController
    {
        private static List<Vendas> vendas = new List<Vendas>();

        public List<Vendas> Get()
        {
            return vendas;
        }

        public void Post(string nome, string data, int formaPagamento, int codProduto, string descricao, int quantidade)
        {
            if (!string.IsNullOrEmpty(nome))
                vendas.Add(new Vendas(nome, data, formaPagamento, codProduto, descricao, quantidade));
        }

        public void Delete(string nome, string data, int formaPagamento, int codProduto, string descricao, int quantidade)
        {
            vendas.RemoveAt(vendas.IndexOf(vendas.First(x => x.NomeCliente.Equals(nome))));
        }
    }
}
