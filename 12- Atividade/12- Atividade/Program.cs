using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite o primeiro valor: ");
        double valor1 = double.Parse(Console.ReadLine());

        Console.Write("Digite o segundo valor: ");
        double valor2 = double.Parse(Console.ReadLine());

        if (valor1 > valor2)
        {
            Console.WriteLine($"\nO maior valor é: {valor1}");
        }
        else
        {
            Console.WriteLine($"\nO maior valor é: {valor2}");
        }
    }
}
    