using System;
class Program
{
public static void Main(string[] args)
{
Console.WriteLine("Digite um número: ");
int numero = Convert.ToInt32(Console.ReadLine());
int contador = 0;
Console.WriteLine("\n\rOs números pares entre 0 e {0} são: " ,numero);
while (contador < numero)
{
contador++;
if (contador % 2 == 0 && contador != numero){
Console.WriteLine(contador);
}
}
Console.Write("\n\rPress any key to continue . . . ");
Console.ReadKey(true);
}
}
