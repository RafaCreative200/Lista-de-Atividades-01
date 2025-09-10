using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite a idade em anos: ");
        int anos = int.Parse(Console.ReadLine());

        int idadeEmDias = anos * 365;

        Console.WriteLine($"\nA idade aproximada em dias é: {idadeEmDias} dias");
    }
}
