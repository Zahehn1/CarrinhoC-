using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Calculo
{
    public void Calcular(AdicionarProduto adicionarProduto)
    {
    List<double> precos = adicionarProduto.GetPrecos();
        if (precos.Count == 0) 
        {
            Console.WriteLine("Nenhum preco fornecidos");
            return;
        }   
        double soma = 0;
        foreach (var preco in precos) 
        {
            soma += preco;
        }
        Console.WriteLine($"A soma total dos precos é: {soma:C}");
}
}