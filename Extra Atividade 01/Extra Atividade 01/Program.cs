using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite quanto dinheiro você tem em R$: ");
        double carteira = double.Parse(Console.ReadLine());
        double taxaDolar = 3.45;
        double dolares = carteira / taxaDolar;
        Console.WriteLine($"Com R$ {carteira:F2} você pode comprar US$ {dolares:F2}");
    }
}
