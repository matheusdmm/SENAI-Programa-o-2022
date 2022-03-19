using System;

public class Program
{
    public static void Main(string[] args)
    {
        int numero;

        Console.Write("Insira o número: ");
        numero = Convert.ToInt32(Console.ReadLine());

        if (numero % 3 == 0| numero % 7 == 0)
        {
            Console.WriteLine("O número " + numero + " é multiplo de 3 ou de 7");
        }
        else Console.WriteLine("O número " + numero + " não é multiplo de 3 ou de 7");
    }    
}