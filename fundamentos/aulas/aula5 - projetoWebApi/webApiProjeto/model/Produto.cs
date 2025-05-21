using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webApiProjeto.model
{
    public class Produto
    {
        public int ProdutoId { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string ImgUrl { get; set; }
        public decimal Preco { get; set; }
        public float Estoque { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}