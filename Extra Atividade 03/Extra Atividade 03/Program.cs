using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite o valor de A: ");
        double A = Convert.ToDouble(Console.ReadLine());
        Console.Write("Digite o valor de B: ");
        double B = Convert.ToDouble(Console.ReadLine());
        Console.Write("Digite o valor de C: ");
        double C = Convert.ToDouble(Console.ReadLine());
        double delta = Math.Pow(B, 2) - 4 * A * C;
        Console.WriteLine($"\nO valor de Delta é: {delta}");
    }
}
