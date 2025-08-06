using ExportadorDeDados.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExportadorDeDados.Interfaces
{
   public  interface IFornecedorRepositorio
    {
        //Métodos abstratos 
        void ExportarDados(Fornecedor fornecedor);
    }
}
