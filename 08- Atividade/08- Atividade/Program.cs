using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite um valor (não pode ser zero): ");
        string input = Console.ReadLine();

        if (double.TryParse(input, out double valor))
        {
            if (valor == 0)
            {
                Console.WriteLine("Valor inválido! Zero não é permitido.");
            }
            else if (valor > 0)
            {
                Console.WriteLine("O valor é positivo.");
            }
            else
            {
                Console.WriteLine("O valor é negativo.");
            }
        }
        else
        {
            Console.WriteLine("Entrada inválida! Digite um número válido.");
        }
    }
}
