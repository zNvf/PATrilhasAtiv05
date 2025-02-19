using System;
using System.Collections.Generic;
{
class Program
{
public static void Main()
{
Console.Write("Escolha o tamanho da camiseta (P, M, G): ");
string tamanhos = Console.ReadLine();
string tamanhoscorrigidos = tamanhos.ToUpper();
switch (tamanhoscorrigidos)
{
case "P":
Console.WriteLine("\n\rO tamanho é P e o preço é R$32,00.");
break;
case "M":
Console.WriteLine("\n\rO tamanho é M e o preço é R$36,00.");
break;
case "G":
Console.WriteLine("\n\rO tamanho é G e o preço é R$42,00.");
break;
default:
Console.WriteLine("\n\rTamanho inválido.");
break;
}
Console.Write("\n\rPress any key to continue . . . ");
Console.ReadKey(true);
}
}
}
