using System;
class Programa
{

    static void Main(string[] args)
    {

        Console.WriteLine("Projeto 5 - Caracteres e textos");

        char letra = 'a';
        Console.WriteLine(letra);

        letra = (char) 65;
        Console.WriteLine(letra);


        letra = (char) (65 + 1);
        Console.WriteLine(letra);

        letra = (char)(86 + 1);
        Console.WriteLine(letra);

        string primeiraFrase = "Insira texto legal aqui";
        Console.WriteLine(primeiraFrase);

        string vazia = "";
        Console.WriteLine(vazia);

        letra = ' ';
        Console.WriteLine(letra);

        string cursos = @"Cursos disponiveis: 
- Go 
- C# 
- Python 
- Java";
        Console.WriteLine(cursos);



        Console.WriteLine("Pressione enter para fechar.");
        Console.ResetColor();
        Console.ReadLine();

    }
}