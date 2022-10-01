// O "P" no começo da pasta é para organizar o projeto no Visual Studio.

using System;
class Programa
{

    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 10 - Calcula Poupança");

        double investimento = 1000;

        // rendimento de 0.5% (0.005) ao mês


        int i = 0;
        int meses = 24;
        while(i < meses)
        {
        investimento = investimento + investimento * 0.005;
        Console.WriteLine(investimento);

            i++;
        }



        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Pressione enter para fechar.");
        Console.ResetColor();
        Console.ReadLine();

    }
}