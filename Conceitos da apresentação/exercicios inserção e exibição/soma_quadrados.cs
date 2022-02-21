using System;
					
public class Program
{
	public static void Main()
	{
		// Pessoas
		int ladoQuadrado1 = 10;
		int ladoQuadrado2 = 19;
		
		int areaQuadrado1 = ladoQuadrado1 * ladoQuadrado1;
		int areaQuadrado2 = ladoQuadrado2 * ladoQuadrado2;
		
		int somaAreas = areaQuadrado1 + areaQuadrado2;
		
		Console.WriteLine("A soma das areas dos dois quadrados é: " + somaAreas);

	}
}