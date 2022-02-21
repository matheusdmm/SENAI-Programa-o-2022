using System;

public class Program
{
	public static void Main()
	{
        char grade = 'B';
         
         switch (grade) 
         {
            case 'A':
               Console.WriteLine("Parabéns!");
               break;
            case 'B':
            case 'C':
               Console.WriteLine("Ótimo");
               break;
            case 'D':
               Console.WriteLine("Você passou");
               break;
            case 'F':
               Console.WriteLine("Você está de recuperação");
               break;
               default:
            Console.WriteLine("Nota inválida");
               break;
        }
        Console.WriteLine("Sua nota é: {0}", grade);
        Console.ReadLine();

    }
}