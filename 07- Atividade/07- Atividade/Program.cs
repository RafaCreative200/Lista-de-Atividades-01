using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite um valor: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int valor))
        {
            if (valor > 10)
            {
                Console.WriteLine("É maior que 10!");
            }
            else
            {
                Console.WriteLine("Não é maior que 10!");
            }
        }
        else
        {
            Console.WriteLine("Valor inválido! Digite um número inteiro.");
        }
    }
}
