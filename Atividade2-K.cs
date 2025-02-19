using System;
class Program
{
public static void Main()
{
int contador1 = 0;
string sequencia;
int soma = 0;
Console.WriteLine("Digite uma sequência de números inteiros, caso quiser parar a sequência basta digitar um número negativo: ");
do {
sequencia = Console.ReadLine();
int numero;
if (int.TryParse(sequencia, out numero)){
if (numero < 0) {
break;
}
soma += numero;
}
else {
Console.WriteLine("Valor inválido!");
}
contador1++;
} while(true);
Console.WriteLine("\n\rA soma dos números é {0}.", soma);
Console.Write("\n\rPress any key to continue . . . ");
Console.ReadKey(true);
}
}
