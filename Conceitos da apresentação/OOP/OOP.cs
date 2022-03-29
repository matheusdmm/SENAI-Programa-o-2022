using System;

class AnaliseCredito
{
    // Propriedades privadas
    private string nome;
    private string profissao;
    private double salario;
    private double limite;
    private bool aprovado;

    // Constantes
    private const double rendaBase = 600;
    private const double limiteExp = 0.35;

    // métodos publicos (funções acessiveis)
    
    // Construtor da classe
    public AnaliseCredito(string _nome, string _profissao, double _salario)
    {
        // aqui as variaveis com underline são as incluidas no construtor
        // E depois são assimiladas as variaveis privadas
        nome = _nome;
        salario = _salario;
        profissao = _profissao;

        // chamamos outro método no construtor para calcular uma analise
        // e ver se com o salário é possivel adquirir o cartão
        GetRenda(salario);
    }

    // Método para fazer uma analise de crédito 
    public void Analise()
    {
        if (aprovado == true)
        {
        CalcularLimite();
        Console.WriteLine("Analise aprovada! {0} tem um limite disponivel de: R${1}", nome, limite);
        }
        else Console.WriteLine("Analise recusada, tente novamente após 30 dias.");
    }

    // Métodos privados
    // retorna a possibilidade de adquirir o cartão ou não
    private bool GetRenda(double salario)
    {
        if (salario >= rendaBase) return aprovado = true;
        else return aprovado = false;
    }

    // Calcula o limite baseado em uma taxa fixa
    private double CalcularLimite()
    {
        limite = salario * limiteExp;
        return limite;
    }
  
}

class Program 
{
    static void Main(string[] args) 
    {
        // Chamamos o construtor da classe para criar um objeto
        var jose = new AnaliseCredito("jose", "analista", 1100.00);
        // Chamamos um método publico do objeto
        jose.Analise();
      
    }
}
