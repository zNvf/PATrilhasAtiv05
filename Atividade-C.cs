using System;

class Program
{
public static void Main()
{
Console.WriteLine("Digite a sua data de nascimento (dd/mm/yyyy): ");
DateTime dataaniversario = DateTime.Parse(Console.ReadLine());

DateTime dataatual = DateTime.Now;

TimeSpan datafinal = dataatual - dataaniversario;

double anos = datafinal.TotalDays / 365.25;
double totaldias = Math.Abs(anos);

Console.WriteLine("\n\rA sua idade é " + totaldias.ToString("F0") + ".");

Console.Write("\n\rPress any key to continue . . . ");
Console.ReadKey(true);
}
}
