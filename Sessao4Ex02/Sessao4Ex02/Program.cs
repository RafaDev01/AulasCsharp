Console.WriteLine("Ex 2");

Carro c1 = new Carro("Fiat uno", "Fiat");
var vel = c1.VelocidadeMaxima(115);
int potencia = 110;

Console.WriteLine(potencia);

Console.WriteLine(c1.AumentarPotencia(potencia));

Console.WriteLine(potencia);

Console.WriteLine(c1.AumentarPotencia(ref potencia));

Console.WriteLine(potencia);


Console.ReadKey();

public class Carro
{
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

    public Carro(string modelo, string montadora)
    {
        Modelo = modelo;
        Montadora = montadora;  
    }

    public string? Modelo;
    public string? Montadora;

    public double VelocidadeMaxima(int potencia)
    {
        return potencia * 1.75;
    }
}