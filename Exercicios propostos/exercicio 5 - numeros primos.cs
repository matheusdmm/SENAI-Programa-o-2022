using System;  

public class Program 
{  
    public static void Main(string[] args)  
    {  
        int numero, i, x = 0;  
        bool primo = true;  

        Console.Write("Insira um número: ");    
        numero = Convert.ToInt32(Console.ReadLine());  

        x = numero / 2;    
        for(i = 2; i <= x; i++)    
        {
            if(numero % i == 0)    
            {
                Console.Write("O número " + numero + " não é primo");    
                primo = false;    
                break;    
            }    
        }    
        if (primo == true)    
            Console.Write("O número " + numero + " é primo");       
    }  
}