using System;

public class Program
{
	public static void Main()
	{
      float ladoA = 8.0;
      float ladoB = 8.0;
      float ladoC = 2.0;
      
      if (ladoA < ladoB + ladoC && ladoB < ladoA + ladoC && ladoC < ladoA + ladoB)
      {
        if (ladoA == ladoB && ladoB == ladoC)
        {
          Console.WriteLine("Triangulo equilatero");
        }
        else
          if (ladoA == ladoB || ladoA == ladoC || ladoC == ladoB)
          {
            Console.WriteLine("Triangulo Isoceles");
          }
          else
          {
            Console.WriteLine("Triangulo Escaleno");
          }
        else
          Console.WriteLine("As medidas não configuram um triangulo");
      }
}