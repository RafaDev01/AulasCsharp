Console.WriteLine("");

Animal cachorro = new();
cachorro.Nome = "Rex";
cachorro.Idade = 12;
cachorro.Peso = 6.25;

Animal gato = new();
gato.Nome = "Garfield";
gato.Idade = 6;
gato.Peso = 3;

cachorro.Status();
Console.WriteLine();
gato.Status();

class Animal
{
    public string? Nome;
    public double Peso;
    public int Idade;

    public void Status()
    {
        Console.WriteLine($"Nome: {Nome}\nPeso: {Peso}\nIdade: {Idade}");
    }
}