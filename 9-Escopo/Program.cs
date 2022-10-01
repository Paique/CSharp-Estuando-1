using System;
class Programa
{

    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 7 - Escopo");

        int idadeJoao = 16;
        int QuantidadePessoas = 2;

        string textoAdicional;


        bool acompanhado = QuantidadePessoas > 1;
        
        if (acompanhado == true)
        {
            textoAdicional = "João está acompanhado";
        } else
        {
            textoAdicional = "João está desacompanhado.";
        }

        if (idadeJoao >= 18 || acompanhado)
        {
            Console.WriteLine(textoAdicional);
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