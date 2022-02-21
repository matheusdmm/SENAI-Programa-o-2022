using System;

public class Program
{
	public static void Main()
	{
        float R, A, B;
        int ESCOLHA;

        Console.Write("Informe o primeiro valor: ");
        A = float.Parse(Console.ReadLine());
        Console.Write("Informe o segundo valor: ");
        B = float.Parse(Console.ReadLine());

        Console.WriteLine("1 .............. Adição");
        Console.WriteLine("2 .............. Subtração");
        Console.WriteLine("3 .............. Multiplicação");
        Console.WriteLine("4 .............. Divisão\n");
        Console.Write("Escolha uma opção: ");
        ESCOLHA = int.Parse(Console.ReadLine());

        if (ESCOLHA == 1)
        {
            R = A + B;
            Console.WriteLine("Resultado = " + R);
        }
        if (ESCOLHA == 2)
        {
            R = A - B;
            Console.WriteLine("Resultado = " + R);
        }
        if (ESCOLHA == 3)
        {
            R = A * B;
            Console.WriteLine("Resultado = " + R);
        }
        if (ESCOLHA == 4)
        {
            if (B == 0)
                Console.WriteLine("Erro, divisão por zero!");
            else
            {
                R = A / B;
                Console.WriteLine("Resultado = " + R);
            }

        Console.WriteLine();
        Console.WriteLine("Aperte enter para concluir");
        Console.ReadLine();
        


        }








    }
}