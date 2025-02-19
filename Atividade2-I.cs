using System;
class Program
{
public static void Main()
{
int soma = 0;
string sequencia;
Console.WriteLine("Digite uma sequência de números (para encerrar, digite 'parar'):");

sequencia = Console.ReadLine().Trim().ToLower();

do 
{
int numero;
if (int.TryParse(sequencia, out numero))
{
soma += numero;
}
else if(sequencia != "parar") 
{
Console.WriteLine("Valor inválido! Digite um número inteiro ou 'parar' para encerrar.");
}
sequencia = Console.ReadLine().Trim().ToLower();
} while (sequencia != "parar");

Console.WriteLine("\nA soma dos números é {0}", soma);
Console.WriteLine("\nPress any key to continue . . . ");
Console.ReadKey(true);
}
}
