using System;

class Program
{
    static void Main()
    {
        // Entrada de dados
        Console.Write("Digite a largura da parede (em metros): ");
        double largura = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite a altura da parede (em metros): ");
        double altura = Convert.ToDouble(Console.ReadLine());

        // Cálculo da área
        double area = largura * altura;

        // Cálculo da quantidade de tinta (1 litro = 2 m²)
        double tinta = area / 2;

        // Saída de dados
        Console.WriteLine($"\nA área da parede é {area} m².");
        Console.WriteLine($"Você precisará de {tinta} litros de tinta para pintá-la.");
    }
}
