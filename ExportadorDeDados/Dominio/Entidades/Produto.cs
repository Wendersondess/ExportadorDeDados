using ExportadorDeDados.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExportadorDeDados.Dominio.Entidades
{
    public class Produto
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Nome { get; set; } = string.Empty;
        public decimal Preco { get; set; } = 0m;
        public int Quantidade { get; set; } = 0;
        public StatusProduto Status { get; set; }
        public Guid FornecedorId { get; set; }

        //Composição 
        public Fornecedor Fornecedor { get; set; } = new();
    }
}
