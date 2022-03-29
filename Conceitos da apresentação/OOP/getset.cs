using System;

class Filme 
{
    private string titulo;
    private string diretor;
    private string classificacao;

    public Filme(string _titulo, string _siretor, string _classificacao) 
    {
        titulo = _titulo;
        diretor = _siretor;
        Classificacao = _classificacao;
    }

    public void ExibirFilme() {
        Console.WriteLine("Filme: {0}, dirigido por: {1}. Classificação: {2}", titulo, diretor, classificacao);
    }


    public string Classificacao
    {
        get { return classificacao; }
        set {
            if (value == "L" || value == "10" || value == "12" || value == "14" || value == "16" || value == "18")
            {
                classificacao = value;
            }
            else classificacao = "Nao Classificado";
        }
    }
}

class Program 
{
    static void Main(string[] args) 
    {
        Filme starwars = new Filme("Star Wars ep V: O imperio contra ataca", "Irvin Kershner", "L");
        
        Console.WriteLine(starwars.Classificacao);

        starwars.ExibirFilme();
    }
}