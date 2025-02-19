using System;
class Program
{
public static void Main(string[] args)
{
Console.WriteLine("Digite um número: ");
int numero = Convert.ToInt32(Console.ReadLine());
int contador = 0;
Console.WriteLine("\n\rA tabuada do número {0} é: " ,numero);
while (contador < 11 )
{
int tabuada = numero * contador;
Console.WriteLine( +numero+ " · " +contador+ " = " +tabuada );
contador++;
}
Console.Write("\n\rPress any key to continue . . . ");
Console.ReadKey(true);
}
}
