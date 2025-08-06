using ExportadorDeDados.Controladores;
Console.WriteLine("\nEXPORTADOR DE DADOS DE FORNECEDORES:\n");
Console.Write("\nDIGITE (1)XML ou (2) JSON:");
var opcao = int.Parse(Console.ReadLine());
var controlador = new FornecedorControlador();
controlador.ExecutarExportacao(opcao);
Console.WriteLine("\nDADOS GRAVADOS COM SUCESSO!");
Console.ReadKey();
