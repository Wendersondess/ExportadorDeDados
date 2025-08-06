using ExportadorDeDados.Dominio.Entidades;
using ExportadorDeDados.Enums;
using ExportadorDeDados.Interfaces;
using ExportadorDeDados.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExportadorDeDados.Controladores
{
    public class FornecedorControlador
    {
        public void ExecutarExportacao(int opcao)
        {
            var fornecedor = new Fornecedor()
            {
                Nome = "Fornecedor Teste",
                Telefone = "(21) 99999-9999",
                Produtos = new List<Produto>()
                {
                      new Produto()
                      {
                        Nome = "Notebook Dell",
                        Preco = 5000.0m,
                        Quantidade = 10,
                        Status = StatusProduto.Disponivel
                       },
                       new Produto()
                       {
                            Nome = "Impressora HP",
                            Preco = 600.0m,
                            Quantidade = 0,
                            Status = StatusProduto.Esgotado

                       }
                }
            };
            IFornecedorRepositorio? repositorio = null;
            switch (opcao)
            {
                case 1:
                    repositorio = new FornecedorRepositorioXml(); break;
                case 2:
                    repositorio = new FornecedorRepositorioJson(); break;


            }
            repositorio?.ExportarDados(fornecedor);
        }
    }
}
