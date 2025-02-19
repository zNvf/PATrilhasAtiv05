using System;
class Program
{
public static void Main()
{
int contador = 0;
Console.WriteLine("Digite um número: ");
var numero = int.Parse(Console.ReadLine());
Console.WriteLine("\n\rA tabuada do número {0} é: " ,numero);
do {
int tabuada = numero * contador;
Console.WriteLine( +numero+ " · " +contador+ " = " +tabuada );
contador++;
} while (contador < 11 );
Console.WriteLine( );
Console.WriteLine("\n\rPress any key to continue . . . ");
Console.ReadKey(true);
}
}
