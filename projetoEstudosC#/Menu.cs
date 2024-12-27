using System;
using System.Collections.Generic;

namespace projetoEstudosC_
{
    public class Menu
    {
        public static void Menuzinho()

        {
            AdicionarProduto adicionarProduto = new AdicionarProduto();
            AdicionarProduto listagemProduto = new AdicionarProduto();


            int option;
            Menu menu = new Menu();

            do
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(@"
███╗░░░███╗███████╗███╗░░██╗██╗░░░██╗
████╗░████║██╔════╝████╗░██║██║░░░██║
██╔████╔██║█████╗░░██╔██╗██║██║░░░██║
██║╚██╔╝██║██╔══╝░░██║╚████║██║░░░██║
██║░╚═╝░██║███████╗██║░╚███║╚██████╔╝
╚═╝░░░░░╚═╝╚══════╝╚═╝░░╚══╝░╚═════╝░");
                Console.ResetColor();

                Console.WriteLine("=========================================");
                Console.WriteLine("  1 - Adicionar Produto                  ");
                Console.WriteLine("  2 - Listar Produtos                    ");
                Console.WriteLine("  3 - Calcular Valor Total               ");
                Console.WriteLine("  0 - Sair                               ");
                Console.WriteLine("=========================================");
                Console.Write("Digite sua opção: ");

                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        adicionarProduto.Add();
                        break;
                    case 2:
                        listagemProduto.ListarProdutos(adicionarProduto);
                        break;
                    case 3:
                        Calculo calculo = new Calculo();
                        calculo.Calcular(adicionarProduto);
                        break;
                    default:
                        Console.WriteLine("Saindo do sistema, até logo");
                        break;
                }
            } while (option != 0);
        }
    }
}
