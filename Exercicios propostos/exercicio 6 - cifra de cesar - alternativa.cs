using System;
using System.Collections.Generic;
using System.Text;

namespace Cifra
{
    class Program 
    {

        /*
        *   A cifra de césar é um dos algoritmos de criptografia mais antigos
        *   de que se tem conhecimento. 
        *
        *   A B C D E F G H I ...
        *   C D E F G H I J K ...
        *
        *   O algoritmo consiste em alocar as letras do alfabeto e depois em
        *   deslocar um numero X de vezes as letras, embaralhando assim a mensagem.
        *
        */

        // Método "moderno" e mais simples de se entender, aceita espaços e caracteres
        // especiais

        public static char Cifra(char ch, int chave) 
        {
            // Logica principal da cifra
            // primeiro verificamos se é uma letra, caractere especial ou um numero
            if (!char.IsLetter(ch)) 
            {
                // caso seja diferente de letra, retornamos o mesmo caractere
                return ch;
            }
            // verificamos se o caractere é maiusculo ou minusculo,
            // para preservar a semelhança com o texto original
            char normalizar = char.IsUpper(ch) ? 'A' : 'a';
            
            // depois realizamos a lógica de adicionar o valor da chave ao alfabeto
            return (char)((((ch + chave) - normalizar) % 26) + normalizar);
        }

        public static string CifrarPalavra(string entrada, int chave) 
        {
            // Método para encriptografar
            // alocamos uma string vazia para a saida
            // usamos o string.Empty para não dar erro de 
            // local variavel não assimilada
            string saida = string.Empty;

            // depois iteramos pela entrada, aplicando a cifra para cada letra
            foreach (char ch in entrada)
            {
                // e salvando o valor na variavel da saida
                saida += Cifra(ch, chave);
            }

            // retornamos o valor da saida
            return saida;
        }

        public static string Decifrar(string entrada, int chave) 
        {
            // método para desencriptografar
            return CifrarPalavra(entrada, 26 - chave);
        }

        static void Main(string[] args) 
        {
            string teste = "dragoes de garagem";
            int chave = 5;

            string teste2 = CifrarPalavra(teste, chave);
            Console.WriteLine(teste2);
            Console.Write("\n");

            Console.WriteLine("\n\n");

            string t = Decifrar(teste2, chave);
            Console.WriteLine(t);
        }
    }
}