using ExportadorDeDados.Dominio.Entidades;
using ExportadorDeDados.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ExportadorDeDados.Repositorios
{
    public class FornecedorRepositorioXml : IFornecedorRepositorio
    {
        public void ExportarDados(Fornecedor fornecedor)
        {
            //Configurar o tipo de classe que será serializada
            var xml = new XmlSerializer(typeof(Fornecedor));
            //Criando um arquivo XML na máquina do usuário
            using (var streamWriter = new StreamWriter
                ($"c:\\temp\\fornecedor_{fornecedor.Id}.xml"))
            {
                //Gravar os dados do fornecedor  
                //em formato XML dentro do arquivo
                xml.Serialize(streamWriter, fornecedor);
            }
        }
    }
}
