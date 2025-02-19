using System;
class Program
{
public static void Main()
{
int soma = 0;
string sequencia;
Console.WriteLine("Digite uma sequência de números(para encerrar a sequência digite parar): ");
while ((sequencia = Console.ReadLine().Trim().ToLower()) != "parar" )
{
int numero;
if (int.TryParse(sequencia, out numero)){
soma += numero;
}
else {
Console.WriteLine("Valor inválido! Ou digite parar para encerrar e somar a sequência.");
}
}
Console.WriteLine("\n\rA soma dos números é {0}", soma);
Console.Write("\n\rPress any key to continue . . . ");
Console.ReadKey(true);
}
}
