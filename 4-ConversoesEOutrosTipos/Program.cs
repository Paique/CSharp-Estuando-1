using System;
class Programa
{

    static void Main(string[] args)
    {

        double salario;
        salario = 3000.15;
        Console.WriteLine(salario);

        int salarioInteiro;
        salarioInteiro = (int)salario;
        Console.WriteLine(salarioInteiro);

        long x;
        x = 2000000000000000000;
        Console.WriteLine(x);


        short y;
        y = 32767;
        Console.WriteLine(y);


        float altura = 1.62f;
        Console.WriteLine(altura);


        Console.WriteLine("Pressione enter para fechar.");
        Console.ReadLine();

    }
}
