Console.WriteLine("## ##");

MinhaClasse m1 = new MinhaClasse();

m1.Saudacao("Maria",DateTime.Now.ToShortDateString());

Console.ReadKey();

public class MinhaClasse
{
    public void Saudacao(string nome, string data)
    {
        Console.WriteLine(nome);
        Console.WriteLine(data);
    }
}