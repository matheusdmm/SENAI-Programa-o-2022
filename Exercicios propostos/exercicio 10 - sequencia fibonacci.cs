using System;

class Fibonacci 
{

    static void Recursivo(int n1, int n2, int total, int numero)
    {
        Console.Write(n1 + " ");
        if (total < numero)
        {
            Recursivo(n2, n1 + n2, total + 1, numero);
        }
    }

    static void Iterativo(int n1, int n2, int total, int numero)
    {
        int proximo;

        if (numero < 2)
        {
            Console.Write("Precisa de mais do que dois elementos para calcular a sequencia");
        }
        else
        {
            Console.Write(n1 + " " + n2);
            
            for (int i = 2; i < total; i++)
            {
                proximo = n1 + n2;
                Console.Write(proximo + " ");
                n1 = n2;
                n2 = proximo;
            }
        }
    }


    static void Main(string[] args)
    {
        // 1,1,2,3,5,8,13...

        int n1, n2, total, numero;

        n1 = 0;
        n2 = 1;
        total = 1;
        numero = 30;

        Recursivo(n1, n2, total, numero);

        Console.WriteLine("\n\n\n");

        Iterativo(n1, n2, total, numero);

    }
    

}