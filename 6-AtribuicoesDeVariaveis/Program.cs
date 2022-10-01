using System;
class Programa
{

    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 6 - Atribuições de variáveis");

        int idade = 30;
        int idadeAna = idade;

        Console.WriteLine(idade);

        idade = 25;

        Console.WriteLine("Pressione enter para fechar.");
        Console.ResetColor();
        Console.ReadLine();

    }
}