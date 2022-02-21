using System;

public class Arrays
{
    public static void Main()
    {
        // Declaramos um array int de 5 posições sem nenhum dado
        int[] array1 = new int[5];

        // Declaramos um array int de 5 posições com os dados já declarados
        int[] array2 = new int[] { 1, 3, 5, 7, 9 };

        // Também podemos declarar um array da seguinte forma (a mais comum)
        int[] array3 = { 1, 2, 3, 4, 5, 6 };

        // Declarando um array de duas dimensões
        int[,] multiDimensionalArray1 = new int[2, 3];

        // Declarando um array de duas dimensões já com dados
        int[,] multiDimensionalArray2 = { { 1, 2, 3 }, { 4, 5, 6 } };
		
		// Exibindo o terceiro item de array2
		// VAI EXIBIR 7 NO CONSOLE
		// Pois na computação sempre começamos a contar a partir de zero
		Console.WriteLine(array2[3]);
		
		// Inserindo um item no indice 3d do nosso array1
		array1[3] = 10;
		Console.WriteLine(array1[3]);
		
    }
}