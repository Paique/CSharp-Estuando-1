using System;
class Programa
{

    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 7 - Condicionais");

        int idadeJoao = 16;
        int QuantidadePessoas = 2;

        if (idadeJoao >= 18)
        {
            Console.WriteLine("Po");
        }
        else if (QuantidadePessoas > 1)
        {
            Console.WriteLine("Acompanhado, po entrar");
        }
        else
        {
            Console.WriteLine("Num pode");
        }

        Console.WriteLine("Pressione enter para fechar.");
        Console.ResetColor();
        Console.ReadLine();

    }
}