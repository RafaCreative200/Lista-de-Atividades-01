using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite a largura da parede (em metros): ");
        double largura = Convert.ToDouble(Console.ReadLine());
        Console.Write("Digite a altura da parede (em metros): ");
        double altura = Convert.ToDouble(Console.ReadLine());
        double area = largura * altura;
        double tinta = area / 2;
        Console.WriteLine($"\nA área da parede é {area} m².");
        Console.WriteLine($"Você precisará de {tinta} litros de tinta para pintá-la.");
    }
}
