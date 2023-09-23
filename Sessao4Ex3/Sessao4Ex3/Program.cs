Console.WriteLine("Atividade");

Carro chevrolet = new Carro("Sedan", "Chevrolet", "Onix", 2016, 110);
chevrolet.Modelo = "Sedan";
chevrolet.Montadora = "Chevrolet";
chevrolet.Marca = "Onix";
chevrolet.Ano = 2016;
chevrolet.Potencia = 110;

chevrolet.ExibirInfo("Onix", "SUV", "Chevrolet", 100);
Console.WriteLine();
chevrolet.ExibirInfo("Onix", "SUV", "Chevrolet", 100, 2020);

Console.ReadLine();

public class Carro
{
    public Carro(string Modelo, string Montadora, string Marca, int Ano, int Potencia)
    {
        this.Modelo = Modelo;
        this.Montadora = Montadora;
        this.Marca = Marca;
        this.Ano = Ano;
        this.Potencia = Potencia;
    }

    public string? Modelo;
    public string? Montadora;
    public string? Marca;
    public int Ano;
    public int Potencia;
    public double Velocidade;

    public void ExibirInfo(string modelo, string montadora, string marca, int potencia, int ano = 0000)
    {
        Console.WriteLine($"Modelo: {modelo}");
        Console.WriteLine($"Montadora: {montadora}");
        Console.WriteLine($"Marca: {marca}");
        Console.WriteLine($"Potencia: {potencia}");
        Console.WriteLine($"Ano: {ano}");
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
