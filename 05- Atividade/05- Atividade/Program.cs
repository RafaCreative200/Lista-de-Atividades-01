using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite o número total de eleitores: ");
        int totalEleitores = int.Parse(Console.ReadLine());

        Console.Write("Digite o número de votos brancos: ");
        int brancos = int.Parse(Console.ReadLine());

        Console.Write("Digite o número de votos nulos: ");
        int nulos = int.Parse(Console.ReadLine());

        Console.Write("Digite o número de votos válidos: ");
        int validos = int.Parse(Console.ReadLine());

        if (brancos + nulos + validos != totalEleitores)
        {
            Console.WriteLine("\nErro: a soma dos votos não confere com o total de eleitores, por favor, insira os dados corretamente.");
        }
        else
        {
            double percBrancos = (brancos * 100.0) / totalEleitores;
            double percNulos = (nulos * 100.0) / totalEleitores;
            double percValidos = (validos * 100.0) / totalEleitores;

            Console.WriteLine($"\nPercentual de votos brancos: {percBrancos:F2}%");
            Console.WriteLine($"Percentual de votos nulos: {percNulos:F2}%");
            Console.WriteLine($"Percentual de votos válidos: {percValidos:F2}%");
        }
    }
}
