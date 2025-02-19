using System;
using System.Collections.Generic;
namespace fire
{
class Program
{
public static void Main()
{
Console.WriteLine("Digite um número: ");
string opcao = (Console.ReadLine());
switch (opcao)
{
case "1":
Console.WriteLine("\n\rO dia correspondente é domingo.");
break;
case "2":
Console.WriteLine("\n\rO dia correspondente é segunda-feira.");
break;
case "3":
Console.WriteLine("\n\rO dia correspondente é terça-feira.");
break;
case "4":
Console.WriteLine("\n\rO dia correspondente é quarta-feira.");
break;
case "5":
Console.WriteLine("\n\rO dia correspondente é quinta-feira.");
break;
case "6":
Console.WriteLine("\n\rO dia correspondente é sexta-feira.");
break;
case "7":
Console.WriteLine("\n\rO dia correspondente é sábado.");
break;
default:
Console.WriteLine("\n\rÉ uma consoante.");
break;
}
Console.Write("\n\rPress any key to continue . . . ");
Console.ReadKey(true);
}
}
}
