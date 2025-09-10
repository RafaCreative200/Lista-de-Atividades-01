using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite o primeiro valor: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Digite o segundo valor: ");
        int b = int.Parse(Console.ReadLine());

        Console.Write("Digite o terceiro valor: ");
        int c = int.Parse(Console.ReadLine());

      
        int[] valores = { a, b, c };
        
        Array.Sort(valores);
        Console.WriteLine("Valores em ordem crescente:");
        foreach (int v in valores)
        {
            Console.Write(v + " ");
        }
    }
}
