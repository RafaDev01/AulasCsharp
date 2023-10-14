using Sessao4ExPrincipal;
using System.Security.Cryptography;

Console.WriteLine("Atividade");

Console.WriteLine($"{CarroEnum.Branco} - {(int)CarroEnum.Branco}");

Carro chevrolet = new Carro("Sedan", "Chevrolet", "Onix", 2016, 110, 5);

Console.WriteLine();
chevrolet.ExibirInfo();

Carro carro = new Carro("Sedan", "Chevrolet", "Onix", 2016, 110, 5);

Console.ReadLine();

public class Carro
{
    static Carro()
    {
        ValorIpva = 4;
        Console.WriteLine($"Porcentagem do IPVA sobre o valor do veículo: {ValorIpva}%");
    }

    public int Cor;
    private int ano;
    public int Ano
    {
        get { return ano; }
        set
        {
            if (value < 2000)
                ano = 2000;
            else if (value > 2022)
                ano = 2022;
            else
                ano = value;
        }
    }
    public Carro(string modelo, string montadora, string marca, int ano, int potencia,int cor)
    {
        Modelo = modelo;
        Montadora = montadora;
        Marca = marca;
        Ano = ano;
        Potencia = potencia;
        Cor = cor;
    }

    public static double ValorIpva;
    public string? Modelo;
    public string? Montadora;
    public string? Marca;
    

    public int Potencia;
    public double Velocidade;

    public void ExibirInfo()
    {
        Console.WriteLine($"Modelo: {Modelo}");
        Console.WriteLine($"Montadora: {Montadora}");
        Console.WriteLine($"Marca: {Marca}");
        Console.WriteLine($"Potencia: {Potencia}");
        Console.WriteLine($"Ano: {ano}");
        Console.WriteLine($"Cor: {(CarroEnum)Cor}");
    }

    public int AumentarPotenciaVelocidade(int potencia, out double velocidade)
    {
        velocidade = potencia * 1.75;
        Potencia += 7;
        return potencia;
    }

    public void Acelerar(string marca)
    {
        Console.WriteLine($"Acelerando o meu {marca}");
    }

    public void Status()
    {
        Console.WriteLine($"{Modelo}, {Montadora}, {Marca}, {Ano}, {Potencia}");
    }

    public int AumentarPotencia(int potencia)
    {
        potencia += 3;
        return potencia;
    }

    public int AumentarPotencia(ref int potencia)
    {
        potencia += 5;
        return potencia;
    }

    public double VelocidadeMaxima(int potencia)
    {
        return potencia * 1.75;
    }
}
