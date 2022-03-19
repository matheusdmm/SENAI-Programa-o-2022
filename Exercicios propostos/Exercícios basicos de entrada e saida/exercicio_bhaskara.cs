using System;

class Program {

    public static int Pow(int n) 
    {
        int pow;
        pow = 1 * n;
        return pow;
    }
    
    public static void Main (string[] args) {

        // b²-4ac
        // x = +- sqrt(b² - 4a * c ) / 2 * a 
        //
        // Valor de teste
        // a = 1, b = 12 e c = – 13

        int delta, a, b, c;
        double x;
        
        Console.Write("Insira o valor de a: ");
        a = Convert.ToInt32(Console.ReadLine());
      
        Console.Write("Insira o valor de b: ");
        b = Convert.ToInt32(Console.ReadLine());

        Console.Write("Insira o valor de c: ");
        c = Convert.ToInt32(Console.ReadLine());
        

        delta = Pow(b) - 4 * (a * c);

        int temp1 = (Pow(b) - 4 * a * c);
        double temp2 = temp1;
      
        x = Math.Sqrt(temp2) / 2 * a;
        
        Console.Write("O valor de x' é: {0}\n", x);

        x = (x * -1);

        Console.Write("O valor de x'' é: {0}", x);

      }
}