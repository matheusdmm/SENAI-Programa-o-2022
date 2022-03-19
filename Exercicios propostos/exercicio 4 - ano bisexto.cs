using System;

public class Program
{
    public static void Main( )
    {
        int ano;
        bool bisexto = false;

        Console.Write("Insira o ano para verificação: ");
        ano = Convert.ToInt32(Console.ReadLine());

        // Primeiro verificamos se o ano é divisivel por 4
        if (ano % 4 == 0)
        {
            // Se for, é setado a variavel para verdadeiro e o loop continua
            bisexto = true;
            // Verificamos se é divisivel por 100
            if (ano % 100 == 0)
            {
                // Caso positivo, verificamos de novo se é divisivel por 400
                // Se positivo, é setada a variavel de novo para veradeira
                if (ano % 400 == 0) bisexto = true;
                else bisexto = false;
            }
        }
        // Caso contrario, continua falso a variavel
        else
            bisexto = false;
        // Se a variavel NÃO FOR FALSA, entao significa que o ano é bisexto
        if (!bisexto) 
            Console.WriteLine(ano + " Não é bisexto");
        else
            Console.WriteLine(ano + " É bisexto");


    }
}