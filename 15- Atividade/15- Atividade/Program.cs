// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Números entre 100 e 2000 que deixam resto 5 quando divididos por 11:");

        for (int i = 100; i <= 2000; i++)
        {
            if (i % 11 == 5)
            {
                Console.WriteLine(i);
            }
        }
    }
}
