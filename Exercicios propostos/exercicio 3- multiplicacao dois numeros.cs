using System;

public class Program
{
    public static void Main( )
    {
        int valor1, valor2, multiplicacao, soma;

        Console.Write("Insira o primeiro valor: ");
        valor1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Insira o segundo valor: ");
        valor2 = Convert.ToInt32(Console.ReadLine());

        multiplicacao = valor1 * valor2;
        soma = valor1 + valor2;

        if (multiplicacao % 2 == 0 | multiplicacao % 3 == 0)
        {
            Console.WriteLine("É divisivel entre 2 ou 3, o resultado da multiplicação é: " + multiplicacao);
        }
        else
            Console.WriteLine("Não é divisivel entre 2 ou 3, o resultado da soma é: " + soma);
    }
}