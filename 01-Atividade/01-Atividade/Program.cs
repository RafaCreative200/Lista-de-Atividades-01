using System;

class Program
{
    static void Main(string[] args)
    {
        int a = 10;
        int b = 20;

        int temp = a;
        a = b;
        b = temp;

        Console.WriteLine($"O valor de A é: {a}");
        Console.WriteLine($"O valor de B é: {b}");

    }
}
