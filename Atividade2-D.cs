using System;
class Program
{
public static void Main()
{
int contador = 2;
string senha;
string senhacorreta;
int contador2 = 1;
Console.WriteLine("Digite uma senha: ");
senha = Console.ReadLine();
Console.WriteLine("\n\rAgora tente adivinhar sua senha! Você possui três tentativas.");
while (contador >= 0 && contador2 < 4)
{
Console.WriteLine("\n\r|Tentativa {0}|", contador2);
senhacorreta = Console.ReadLine();
if (senhacorreta == senha){
Console.WriteLine("Parabéns! Você acertou a senha.");
break; }
else {
Console.WriteLine("Senha incorreta! Você possui mais {0} tentativas.", contador);
}
contador--;
contador2++;
}
Console.Write("\n\rPress any key to continue . . . ");
Console.ReadKey(true);
}
}
