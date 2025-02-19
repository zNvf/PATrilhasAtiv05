using System;
using System.Collections.Generic;

class Program
{
public static void Main()
{
List<DateTime> feriadosnacionais = new List<DateTime> 
{
new DateTime(DateTime.Now.Year, 1 ,1), 
new DateTime(DateTime.Now.Year, 4, 21),
new DateTime(DateTime.Now.Year, 9, 7),
new DateTime(DateTime.Now.Year, 10, 12),
new DateTime(DateTime.Now.Year, 11, 15),
new DateTime(DateTime.Now.Year, 12, 25) 
};

Console.WriteLine("Digite uma data (dd/mm/yyyy): ");
DateTime data = DateTime.Parse(Console.ReadLine());

if (feriadosnacionais.Contains(data))
{ 
Console.WriteLine("\n\rA data inserida é um feriado nacional");
}

else{
Console.WriteLine("\n\rA data não é um feriado nacional");
}

Console.Write("\n\rPress any key to continue . . . ");
Console.ReadKey(true);
}
}
