// Início do exercício.

Console.Clear();

System.Console.WriteLine("Seja bem vindo(a) ao exercício 'Negativo'!\n");

Console.ForegroundColor = ConsoleColor.Gray;
System.Console.WriteLine("aperte qualquer tecla para continuar...");
Console.ReadKey();
Console.ResetColor();

// O exercício em si.
Console.Clear();

int NumeroUsuario;

System.Console.WriteLine("Digite um número, que vou dizer se ele é negativo ou não.\n");
System.Console.WriteLine("Número:");
NumeroUsuario = Convert.ToInt32(Console.ReadLine());

if (NumeroUsuario < 0)
{
    System.Console.WriteLine("Você digitou um número negativo.");
}

else
{
    System.Console.WriteLine("Você digitou um número positivo.");
}