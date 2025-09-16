// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite um número inteiro: ");
        int n = int.Parse(Console.ReadLine());

        if (n < 0)
        {
            Console.WriteLine("Fatorial não existe para números negativos.");
        }
        else
        {
            long resultado = Fatorial(n);
            Console.WriteLine($"{n}! = {resultado}");
        }
    }

    static long Fatorial(int n)
    {
        if (n == 0) return 1; // definição: 0! = 1

        long fat = 1;
        for (int i = 1; i <= n; i++)
        {
            fat *= i;
        }
        return fat;
    }
}

