using System;
					
public class Program
{
	public static void Main()
	{
		// Pessoas
		string nome = "João";
		string nome2 = "Patricia";
		string nome3 = "Marcelo";
		string nome4 = "Eduarda";
		
		// Cidades
		string cidade = "Santa Cruz do Sul";
		string cidade2 = "São Paulo";
		string cidade3 = "Lajeado";
		string cidade4 = "Rio Pardo";
		
		// Idades
		int idade = 22;
		int idade2 = 19;
		int idade3 = 29;
		int idade4 = 20;
		
		// Animais de estimação
		string animal = "gato";
		string animal2 = "cachorro";
		
		// Exibir a lista
		Console.WriteLine("O nome é: " + nome + ", " + idade + " de: " + cidade + " e o animal de estimação é: " + animal);
		Console.WriteLine("O nome é: " + nome2 + ", " + idade2 + " de: " + cidade2 + " e o animal de estimação é: " + animal2);
		Console.WriteLine("O nome é: " + nome3 + ", " + idade3 + " de: " + cidade3 + " e o animal de estimação é: " + animal2);
		Console.WriteLine("O nome é: " + nome4 + ", " + idade4 + " de: " + cidade4 + " e o animal de estimação é: " + animal);
	}
}