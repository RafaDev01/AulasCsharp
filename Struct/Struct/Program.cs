Console.WriteLine("## Struct ##");
Console.WriteLine("A alocação é feito na stack e não na heap");

Cliente c1 = new();

c1.Nome = "Maria";
c1.Idade = 20;

Console.WriteLine($"{c1.Nome} {c1.Idade}");

Console.ReadKey();

public struct Cliente
{
    public string? Nome { get; set; }
    public int Idade { get; set; }

    public Cliente(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }
}