using System;
					
public class Program
{
	public static void Main()
	{
		// Pessoas
        Console.WriteLine("Insira o nome de 4 pessoas")
		string nome = Console.ReadLine();
		string nome2 = Console.ReadLine();
		string nome3 = Console.ReadLine();
		string nome4 = Console.ReadLine();
		
		// Cidades
        Console.WriteLine("Insira o nome de 4 cidades")
		string cidade = Console.ReadLine();
		string cidade2 = Console.ReadLine();
		string cidade3 = Console.ReadLine();
		string cidade4 = Console.ReadLine();
		
		// Idades
        Console.WriteLine("Insira as respectivas idades")
		int idade = Console.ReadLine();
		int idade2 = Console.ReadLine();
		int idade3 = Console.ReadLine();
		int idade4 = Console.ReadLine();
		
		// Animais de estimação
        Console.WriteLine("Insira os animais de estimação de cada um")
		string animal = Console.ReadLine();
		string animal2 = Console.ReadLine();
        string animal3 = Console.ReadLine();
        string animal4 = Console.ReadLine();
		
		// Exibir a lista
		Console.WriteLine("O nome é: " + nome + ", " + idade + " de: " + cidade + " e o animal de estimação é: " + animal);
		Console.WriteLine("O nome é: " + nome2 + ", " + idade2 + " de: " + cidade2 + " e o animal de estimação é: " + animal2);
		Console.WriteLine("O nome é: " + nome3 + ", " + idade3 + " de: " + cidade3 + " e o animal de estimação é: " + animal3);
		Console.WriteLine("O nome é: " + nome4 + ", " + idade4 + " de: " + cidade4 + " e o animal de estimação é: " + animal4);
	}
}