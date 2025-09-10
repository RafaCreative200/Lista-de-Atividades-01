using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite o salário mensal atual: R$ ");
        double salarioAtual = double.Parse(Console.ReadLine());

        Console.Write("Digite o percentual de reajuste (%): ");
        double percentual = double.Parse(Console.ReadLine());

        double novoSalario = salarioAtual + (salarioAtual * percentual / 100);

        Console.WriteLine($"\nO novo salário é: R$ {novoSalario:F2}");
    }
}
