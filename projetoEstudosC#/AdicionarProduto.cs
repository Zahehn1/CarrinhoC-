using System;
using System.Collections.Generic;

public class AdicionarProduto
{
    List<string> nomes = new List<string>();
    List<double> precos = new List<double>();
    public void Add()
    {


        for (int i = 0; i < 2; i++)
        {
            Console.WriteLine("Adicione um nome ao produto");
            string nomeInserido = Console.ReadLine();
            nomes.Add(nomeInserido);

            Console.WriteLine("Adicione um preço ao produto");
            bool precoValido = double.TryParse(Console.ReadLine(), out double preco);
            if (precoValido)
            {
                precos.Add(preco);
            }
            else
            {
                Console.WriteLine("Preço inválido! O valor não será adicionado.");
                i--;
            }
        }
    }
    public List<double> GetPrecos(){return precos;}
    public List<string> GetNomes() { return nomes; }
    public void ListarProdutos(AdicionarProduto adicionarProduto)
    {
        List<string> nomes = adicionarProduto.GetNomes();
        if (nomes.Count == 0)
        {
            Console.WriteLine("Ainda nao ha produto adicionado");
        }

        for (int i = 0; i < nomes.Count; i++)
        {
            Console.WriteLine($"Produtos: {nomes[i]}");
        }
    }
}
       
    


