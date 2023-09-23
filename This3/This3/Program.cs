Console.WriteLine("## this ##");

Teste t1 = new Teste(50);

Console.ReadLine();

public class Teste
{
    public Teste(int num1, int num2)
    {
        Console.WriteLine($"\nConstrutor com dois parâmetros {num1} e {num2}");
    }

    public Teste(int num) : this(777,888)
    {
        Console.WriteLine("Construtor com 1 parametros");
    }
}