using ExportadorDeDados.Dominio.Entidades;
using ExportadorDeDados.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExportadorDeDados.Repositorios
{
   public class FornecedorRepositorioJson : IFornecedorRepositorio
    {
        public void ExportarDados(Fornecedor fornecedor)
        {
            //Serializar os dados para formato JSON
            var json = JsonConvert.SerializeObject
                (fornecedor, Formatting.Indented);

            //Criando um arquivo na máquina do usuário para gravar os dados
            using (var streamWriter = new StreamWriter
                ($"c:\\temp\\fornecedor_{fornecedor.Id}.json"))
            {
                //Escrever os dados no arquivo
                streamWriter.Write(json);
            }
        }
    }
}
