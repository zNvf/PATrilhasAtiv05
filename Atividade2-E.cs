using System;
class Program
{
public static void Main()
{
int soma = 0;
string sequencia;
Console.WriteLine("Digite uma sequência de números inteiros(para encerrar a sequência digite algum número negativo): ");
while (true)
{
sequencia = Console.ReadLine();
int numero;
if (int.TryParse(sequencia, out numero) )
{
if (numero < 0) {
break;
}
soma += numero;
}
else {
Console.WriteLine("Valor inválido! Digite apenas números inteiros.");
}
}
Console.WriteLine("\n\rA soma dos números é {0}", soma);
Console.Write("\n\rPress any key to continue . . . ");
Console.ReadKey(true);
}
}
