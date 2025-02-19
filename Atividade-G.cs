using System;
using System.Collections.Generic;
namespace fire
{
class Program
{
public static void Main()
{
Console.WriteLine("===================== ");
Console.WriteLine("+      Azul         +");
Console.WriteLine("+      Verde        +");
Console.WriteLine("+      Vermelha     +");
Console.WriteLine("===================== ");
Console.WriteLine("\n\rEscolha uma das três cores: ");
string cor = Console.ReadLine();
switch (cor)
{
case "Azul":
Console.WriteLine("\n\rVocê escolheu a cor azul.");
break;
case "Verde":
Console.WriteLine("\n\rVocê escolheu a cor verde.");
break;
case "Vermelha":
Console.WriteLine("\n\rVocê escolheu a cor vermelha.");
break;
default:
Console.WriteLine("\n\rCor Invalida.");
break;
}
Console.Write("\n\rPress any key to continue . . . ");
Console.ReadKey(true);
}
}
}
