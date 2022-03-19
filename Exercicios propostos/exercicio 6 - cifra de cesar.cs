using System;  

public class Program 
{  
    /*
    *   A cifra de césar é um dos algoritmos de criptografia mais antigos
    *   de que se tem conhecimento. 
    *
    *
    *   O algoritmo consiste em alocar as letras do alfabeto e depois em
    *   deslocar um numero X de vezes as letras, embaralhando assim a mensagem.
    *
    */

    // Método clássico, usando arrays e alocando cada palavra separadamente
    // porém como ponto negativo, ele não funciona em frases ou palavras com espaços

    public static string Cifra(string frase, int chave)
    {
        // lógica da cifra

        // declarar um array com o alfabeto
        char[] alfabeto = {
            'a','b','c','d','e','f','g','h',
            'i','j','k','l','m','n','o','p','q',
            'r','s','t','u','v','w','x','y','z'
        };

        // normalizamos a frase para apenas caracteres em
        // letra minuscula
        frase = frase.ToLower();

        // primeiro transformar a frase em um array com o método
        // ToCharArray()
        char[] fraseArray = frase.ToCharArray();

        // depois alocar um array para a mensagem encriptada
        char[] mensagemCifrada = new char[fraseArray.Length];

        // iterar pelo array da frase inicial
        for (int i = 0; i < fraseArray.Length; i++)
        {
            // definir uma variavel para cada letra do array
            char letra = fraseArray[i];

            // depois alocar a posição de cada uma dentro da tabela
            int posicaoLetra = Array.IndexOf(alfabeto, letra);

            // e salvar a nova posição da letra, usando 
            int novaPosicaoLetra = (posicaoLetra + chave) % 26;
            char letraCifrada = alfabeto[novaPosicaoLetra];
            mensagemCifrada[i] = letraCifrada;
        }

        string cifraString = String.Join("", mensagemCifrada);
        return cifraString;
    }


    public static string Decodificar(string frase, int chave)
    {
        // decodificar
        // armazenar a entrada em uma variavel temporaria
        // e multiplicar o valor da chave por -1 para ter o valor de casas retrocedido na tabela
        var temp = Cifra(frase, chave * -1);
        return temp;

    }

    public static void Main(string[] args)  
    {  
        int chave = 4;
        string frase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        var test = Cifra(frase, chave);
        Console.WriteLine(test);

        Console.WriteLine("\n\nInsira a frase para criptografar:");
        frase = Console.ReadLine();

        var cifra1 = Cifra(frase, chave);
        Console.WriteLine(cifra1);

        var decrip = Decodificar(cifra1, chave);
        Console.WriteLine(decrip);
    }  
}