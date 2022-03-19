using System;

public class Program
{
    public static void Main(string[] args)
    {
        int numero, i;

        Console.Write("Insira um número: ");
        numero = Convert.ToInt32(Console.ReadLine());

        for (i = numero; i >= 0; i--)
        {
            Console.WriteLine(i);
        }

    }
}