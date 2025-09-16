using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite o preço do produto: ");
        double preco = Convert.ToDouble(Console.ReadLine());

        double desconto = preco * 0.05;
        double precoPromocional = preco - desconto;

        Console.WriteLine($"O preço promocional com 5% de desconto é: R$ {precoPromocional}");
    }
}
