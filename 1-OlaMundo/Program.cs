using System;
class Programa
{

    static void Main(string[] args)
    {
        Console.WriteLine("Olá mundo!");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Pressione enter para fechar.");
        Console.ResetColor();
        Console.ReadLine();

    }
}