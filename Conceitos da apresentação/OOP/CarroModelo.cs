using System;

public class Carro
{
    private int velocidade;
    private string modelo;
    private string marca;
    
    public bool ligado;

    public Carro(int _vel, string _mod, string _marca)
    {
        Velocidade = _vel;
        modelo = _mod;
        marca = _marca;
    }

    public void Ligar(bool _ligado)
    {
        ligado = _ligado;

        if (ligado == true)  LigarMotor(ligado);
        else return ligado;
    }

    public Velocidade 
    {
        get { velocidade; }
        set {
            if (value == 0) velocidade = value;
            else (value > 300) velocidade = 300;
            else if velocidade = velocidade;
        }
    }

    private void LigarMotor(ligado)
    {
        double combustivel = 35.0;

        while (combustivel < 0.0)
        {
            bool bombaCombustivel = true;
            return ligado = true;
        }
    }

    private void Motor(LigarMotor)
    {
        Console.Write("Motor ligado");
    }

}


class Program {
    public static void Main(string[] args)
    {
        peugeot = new Carro(280, "208", "peugeot");
    }
}