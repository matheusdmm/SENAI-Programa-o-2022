using System;
					
public class Program
{
	public static void Main()
	{
		// vamos usar double pois as notas podem ser quebradas
		// E para converter a entrada usamos o método
		// double.Parse()
		Console.WriteLine("Insira a nota das provas:");
		double nota1 = double.Parse(Console.ReadLine());
		double nota2 = double.Parse(Console.ReadLine());
		double nota3 = double.Parse(Console.ReadLine());
		
		// calcular média
		double media = (nota1 + nota2 + nota3) / 3;
		
		// Exibir a média
		Console.WriteLine("A média do aluno é: " + media);

	}
}