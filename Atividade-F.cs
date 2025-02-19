using System;
using System.Collections.Generic;

class Program
{

public static void Main()
{

Console.WriteLine("Digite um número: ");
string numero =Console.ReadLine(); 

switch (numero)    
{	
case "-1": 
Console.WriteLine("\n\rO número é negativo.");
break;

case "0": 
Console.WriteLine("\n\rO número é zero.");
break;			

case "1":
Console.WriteLine("\n\rO numero é positivo.");
break;
default:
Console.WriteLine("\n\rValor Invalido.");
break;
}

Console.Write("\n\rPress any key to continue . . . ");
Console.ReadKey(true);
}
}
