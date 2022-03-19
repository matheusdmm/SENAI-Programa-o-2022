using System;  

public class Program 
{  
    public static void Main(string[] args)  
    {
        int max, i, j, contador;
        
        Console.Write("Até qual número você deseja calcular números primos? ");
        max = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Os números primos até " + max + " são: ");

        // Criamos um for loop externo para delimitar o valor máximo do
        // Nosso calculo
        for (i = 1; i <= max; i++)
        {
            // alocamos um contador para incrementarmos conforme formos
            // calculando
            contador = 0;

            // agora vem a parte que calculamos e verificamos se
            // o numero é divisivel por 1 ou por ele mesmo
            for (j = 2; j <= i / 2; j++)
            {
                if (i % j == 0)
                {
                    contador++;
                    break;
                }
            }

            // Caso seja, ele é exibido aqui    
            if (contador == 0 && i != 1)
            {
                Console.Write(i + " ");
            }    
        }    
    }  
}