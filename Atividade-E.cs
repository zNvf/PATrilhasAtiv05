using System;
using System.Collections.Generic;

class Program
{

public static void Main()
{
Console.WriteLine("===================== ");
Console.WriteLine("+      Opção 1      +");
Console.WriteLine("+      Opção 2      +");
Console.WriteLine("+      Opção 3      +");
Console.WriteLine("===================== ");
		
Console.WriteLine("  \n\rEscolha uma das opções: ");
string escolha = Console.ReadLine();
		
switch (escolha)
{ 
case "1": 
Console.WriteLine("\n\rVocê escolheu a opção 1.");
break;

case "2": 
Console.WriteLine("\n\rVocê escolheu a opção 2.");
break;			
	
case "3":
Console.WriteLine("\n\rVocê escolheu a opção 3.");
break;
}
		
Console.Write("\n\rPress any key to continue . . . ");
Console.ReadKey(true);
}
}
