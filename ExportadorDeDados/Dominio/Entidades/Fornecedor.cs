using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExportadorDeDados.Dominio.Entidades
{
    public class Fornecedor
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Nome { get; set; } = string.Empty;
        public string Telefone { get; set; } = string.Empty;

        //Composição 
        public List<Produto> Produtos { get; set; } = new();
    }
}
