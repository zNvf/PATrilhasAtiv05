using System;
using System.Collections.Generic;
namespace fire
{
class Program
{
public static void Main()
{
Console.WriteLine("Digite uma letra: ");
string letra = Console.ReadLine();
string vogal = letra.ToLower();
switch (vogal)
{
case "a":
Console.WriteLine("\n\rÉ uma vogal.");
break;
case "e":
Console.WriteLine("\n\rÉ uma vogal.");
break;
case "i":
Console.WriteLine("\n\rÉ uma vogal.");
break;
case "o":
Console.WriteLine("\n\rÉ uma vogal.");
break;
case "u":
Console.WriteLine("\n\rÉ uma vogal.");
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
