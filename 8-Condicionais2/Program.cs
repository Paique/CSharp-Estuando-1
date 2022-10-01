using System;
class Programa
{

    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 8 - Condicionais 2");

        int idadeJoao = 16;
        int QuantidadePessoas = 2;

        bool acompanhado = QuantidadePessoas > 1;
        bool grupo = true;

        if (idadeJoao >= 18 || acompanhado)
        {
            Console.WriteLine("Po");
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