Console.WriteLine("## thuis ##");

Cliente c1 = new Cliente("Rafael",24);

Console.ReadKey();

public class Cliente
{
    public string? Nome;
    public int Idade;
    
    public Cliente(string? Nome, int Idade)
    {
        this.Nome = Nome;
        this.Idade = Idade;
    }
}