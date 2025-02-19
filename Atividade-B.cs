using System;

class Program
{
public static void Main()
{
Console.WriteLine("Digite a primeira data (dd/mm/yyyy): ");
DateTime data1 = DateTime.Parse(Console.ReadLine());

Console.WriteLine("\n\rDigite a segunda data (dd/mm/yyyy): ");
DateTime data2 = DateTime.Parse(Console.ReadLine());

TimeSpan datafinal = data1 - data2;

double totaldias = Math.Abs(datafinal.TotalDays);

Console.WriteLine("\n\rA diferença entre as datas é: {0} dias.", totaldias);

Console.Write("\n\rPress any key to continue . . . ");
Console.ReadKey(true);
}
}
