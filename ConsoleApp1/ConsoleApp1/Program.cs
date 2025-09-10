using System;

class Program
{
    static void Main()
    {
        // Lê quanto dinheiro a pessoa tem na carteira
        Console.Write("Digite quanto dinheiro você tem em R$: ");
        double carteira = double.Parse(Console.ReadLine());

        // Taxa de conversão
        double taxaDolar = 3.45;

        // Converte para dólar
        double dolares = carteira / taxaDolar;

        // Exibe o resultado
        Console.WriteLine($"Com R$ {carteira:F2} você pode comprar US$ {dolares:F2}");
    }
}
