using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite o ano atual: ");
        int anoAtual = int.Parse(Console.ReadLine());

        Console.Write("Digite o ano de nascimento: ");
        int anoNascimento = int.Parse(Console.ReadLine());

        int idade = anoAtual - anoNascimento;

        Console.WriteLine($"\nIdade: {idade} anos");

        if (idade < 16)
        {
            Console.WriteLine("Você NÃO é obrigado a votar.");
        }
        else if ((idade >= 16 && idade < 18) || idade > 70)
        {
            Console.WriteLine("Seu voto é FACULTATIVO.");
        }
        else
        {
            Console.WriteLine("Seu voto é OBRIGATÓRIO.");
        }
    }
}
