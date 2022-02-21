using System;

public class Program
{
	public static void Main()
	{
		long FAT = 1, n, I;

        Console.Write("Informe um valor: ");
        n = long.Parse(Console.ReadLine());

        I = 1;
        do
        {
            FAT *= I;
            I++;
        } 
        while (I <= n);

        Console.WriteLine("Fatorial de {0} = {1}", n, FAT);
        Console.ReadLine();
    }
}