using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite a quantidade de maçãs compradas: ");
        int quantidade = int.Parse(Console.ReadLine());

        double preco;

        if (quantidade < 12)
        {
            preco = 1.30;
        }
        else
        {
            preco = 1.00;
        }

        double total = quantidade * preco;

        Console.WriteLine($"O custo total da compra é: R$ {total:F2}");
    }
}
