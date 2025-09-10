using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite a nota da primeira avaliação: ");
        double nota1 = double.Parse(Console.ReadLine());

        Console.Write("Digite a nota da segunda avaliação: ");
        double nota2 = double.Parse(Console.ReadLine());

        double media = (nota1 + nota2) / 2;

        Console.WriteLine($"\nMédia do aluno: {media:F2}");

        if (media >= 6.0)
        {
            Console.WriteLine("Aluno APROVADO!");
        }
        else
        {
            Console.WriteLine("Aluno REPROVADO!");
        }
    }
}
