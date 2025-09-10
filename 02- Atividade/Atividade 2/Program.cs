// See https://aka.ms/new-console-template for more information
Console.Write("Digite um número: ");
int numero = int.Parse(Console.ReadLine());

int antecessor = numero - 1;

Console.WriteLine($"O antecessor de {numero} é {antecessor}");
