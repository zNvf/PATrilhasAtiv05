using System;
class Program
{
public static void Main()
{
int contador1 = 0;
int contador2 = 3;
string senhacorreta;
Console.Write("Crie uma senha: ");
string senha = Console.ReadLine();
Console.WriteLine("\n\rAgora tente acerta-lá! Você possui 3 tentativas.");
do {
Console.Write("\n\r|{0} tentativa|:", contador2);
senhacorreta = Console.ReadLine();
if (senhacorreta == senha) {
Console.WriteLine("\n\rParabéns! Você acertou a senha!");
break;
}
else {
Console.WriteLine("\n\rSenha incorreta!");
}
contador2--;
contador1++;
} while(contador1 < 3 && contador2 > 0);
Console.Write("\n\rPress any key to continue . . . ");
Console.ReadKey(true);
}
}
