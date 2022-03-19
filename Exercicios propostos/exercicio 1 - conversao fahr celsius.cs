using System;

public class Program
{
   public static void Main( )
   {
        int celsius, fahr;
	   
        // Conversão de Celsius para Fahrenheit
        Console.Write("Insira a temperatura em Celsius: "); 
        celsius = Convert.ToInt32(Console.ReadLine());
 
	    fahr = celsius * 18 / 10 + 32;
	   
        Console.WriteLine("Fahrenheit = " + fahr);


        // Conversão de Fahrenheit para Celsius
        Console.Write("Insira a temperatura em Fahrenheit: ");
        fahr = Convert.ToInt32(Console.ReadLine());

        celsius = (fahr - 32) * 5 / 9;

        Console.WriteLine("Celsius = " + celsius);


    }
}