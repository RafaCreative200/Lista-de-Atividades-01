// See https://aka.ms/new-console-template for more information
int num, i, resultado, valor;
Console.WriteLine("Digite um numero para a multiplicação");
num = int.Parse(Console.ReadLine());
Console.WriteLine("Até que numero você quer que seja multiplicado?");
valor = int.Parse(Console.ReadLine());
i = 0;
while(i <=valor )
{
    resultado = i * num;
    Console.WriteLine($"{num} X {i} = {resultado} ");
    i++;
}

