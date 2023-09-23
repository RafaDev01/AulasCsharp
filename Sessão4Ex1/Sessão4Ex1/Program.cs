Console.WriteLine("Ex 1");

Carro chevrolet = new Carro("Sedan", "Chevrolet", "Onix", 2016, 110);
chevrolet.Modelo = "Sedan";
chevrolet.Montadora = "Chevrolet";
chevrolet.Marca = "Onix";
chevrolet.Ano = 2016;
chevrolet.Potencia = 110;

chevrolet.Status();
chevrolet.Acelerar("PastáDeDenté");

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

    public void Acelerar(string marca)
    {
        Console.WriteLine($"Acelerando o meu {marca}");
    }

    public void Status()
    {
        Console.WriteLine($"{Modelo}, {Montadora}, {Marca}, {Ano}, {Potencia}");
    }
}