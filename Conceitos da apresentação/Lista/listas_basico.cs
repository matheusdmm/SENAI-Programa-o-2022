using System;
using System.Collections.Generic;
					
public class Program
{
	public static void Main()
	{
		List<Int32> lista1 = new List<Int32>(); 
		
		Console.WriteLine("Maneira em que o compilador gerencia de forma automática as inserções:");
		
		lista1.Add(1);
		lista1.Add(3);
		lista1.Add(6);
	
		
		foreach (int i in lista1){
			Console.WriteLine(i);
		}
		
		
		Console.WriteLine("\n\nAgora inserindo manualmente o valor 10 no 3 elemento da lista:");
		Console.WriteLine("Lembrando que na computação, a contagem inicia sempre em 0!!");
		
		lista1.Insert(3, 10);
		
		foreach (int i in lista1){
			Console.WriteLine(i);
		}
		
		
		Console.WriteLine("\n\nAgora mudando o valor do elemento 1 (segundo) na lista para 0:");
		
		lista1.Insert(1, 0);
		
		foreach (int i in lista1){
			Console.WriteLine(i);
		}
		
		
		
		Console.WriteLine("\n\nRemovendo itens na lista:");
		Console.WriteLine("Neste caso removendo o elemento 1 (0):");
		
		lista1.RemoveAt(1);
		
		foreach (int i in lista1){
			Console.WriteLine(i);
		}
		
		
		Console.WriteLine("\n\nRemovendo itens na lista de outra maneira:");
		Console.WriteLine("Neste caso removendo o elemento 2 (6):");
		
		lista1.Remove(6);
		
		foreach (int i in lista1){
			Console.WriteLine(i);
		}
		
		
		
		Console.WriteLine("\n\nLimpando a lista:");
		Console.WriteLine("Nota-se que não vai exibir nada na nossa iteração pois não possuimos elementos na lista");
		
		lista1.Clear();
		
		foreach (int i in lista1){
			Console.WriteLine(i);
		}
	
	}
}