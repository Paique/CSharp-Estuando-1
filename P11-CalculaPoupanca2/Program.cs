// O "P" no começo da pasta é para organizar o projeto no Visual Studio.

using System;
class Programa
{

    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 11 - Calcula Poupança 2");

        double investimento = 1000;

        // rendimento de 0.5% (0.005) ao mês


        int i = 0;
        int meses = 24;

        /*
        while (i < meses)
        {
            investimento = investimento + investimento * 0.005;
            Console.WriteLine(investimento);

            i++;
        }
        */

        for(i = 0; i < meses; i++)
        {
            investimento *= 1.005;
            Console.WriteLine(investimento);
        }


        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Pressione enter para fechar.");
        Console.ResetColor();
        Console.ReadLine();

    }
}