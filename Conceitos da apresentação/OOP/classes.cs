using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introdução_a_OOP
{
    // Construimos uma classe toda vez que queremos criar um
    // modelo de algum tipo de informação, para usarmos diversas vezes
    // Neste caso, a classe de uma PESSOA
    public class Pessoa
    {
        // Dentro da classe, atribuimos diversas propriedades,
        // variaveis, métodos e informações, de maneira genérica
        // para depois no código atribuirmos as mesmas de maneira especifica

        // Neste caso, atribuimos variaveis genéricas com nome, cidade
        // hobby e idade de uma pessoa ainda não identificada
        public string nome;
        public string cidade;
        public string hobby;
        public int idade;


        // Dentro das classes, ainda podemos fazer MÉTODOS, que são
        // funções genéricas e que interagem com os elementos da classe

        // Neste caso, temos um método que recebe os valores de
        // nome, cidade, idade e hobby e depois emite uma mensagem de
        // boas apresentação
        public void descricao()
        {
            Console.WriteLine("Olá, eu me chamo " + nome + " sou de " 
                                + cidade + ", tenho " + idade + " e gosto de " + hobby);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Classe PESSOA
            
            // Para utilizarmos e chamarmos a classe PESSOA
            // primeiro precisamos criar uma pessoa

            // Fazemos isso dizendo primeiro o nome da classe, neste caso PESSOA
            // e depois dando o nome que desejamos a esta pessoa, no caso Matheus.
            
            // em outras palavras: CLASSE nomedaclasse = NOVA CLASSE
            Pessoa matheus = new Pessoa();

            // Depois vamos inserir os valores que desejamos, dentro desta nova pessoa criada
            // Para isto, fazemos da seguinte maneira:
            matheus.nome = "Matheus";
            matheus.cidade = "SCS";
            matheus.idade = 27;
            matheus.hobby = "Tocar guitarra";

            // E agora podemos chamar o MÉTODO da classe para exibirmos as boas vindas
            matheus.descricao();


            // Para pausarmos o console
            Console.ReadLine();
        }
    }
}
