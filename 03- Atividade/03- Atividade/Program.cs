using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite o valor da base do retângulo: ");
        double baseRetangulo = double.Parse(Console.ReadLine());

        Console.Write("Digite o valor da altura do retângulo: ");
        double altura = double.Parse(Console.ReadLine());

        double area = baseRetangulo * altura;

        Console.WriteLine($"\nA área do retângulo é: {area:F2}");
    }
}
