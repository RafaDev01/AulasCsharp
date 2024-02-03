
IControle d = new Demo();
d.Nome = "Teste";
d.Desenhar();
d.Exibir();

Demo demo = new Demo();
demo.Pintar();

Console.ReadKey();

interface IControle
{
    string Nome { get; set;  }
    void Desenhar();
    public void Exibir()
    {
        Console.WriteLine("teste");
    }
}

interface IGrafico
{
    void Pintar();
}

public class Demo : IControle, IGrafico
{
    public string Nome { get; set; } = string.Empty; 

    public void Desenhar()
    {
        Console.WriteLine("Desenhando...");
    }

    public void Pintar()
    {
        Console.WriteLine("Pintado...");
    }
}