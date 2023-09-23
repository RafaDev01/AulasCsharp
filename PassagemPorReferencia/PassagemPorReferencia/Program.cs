Console.WriteLine("Passagem por referencia");

int x = 20;

Console.WriteLine("\nValor do argumento X antes de passar por valor " + x);

Calculo calculo = new();
calculo.Dobrar(ref x);
Console.WriteLine("\nValor do argumento X depois de passar por valor " + x);

Console.ReadKey();

public class Calculo
{
    public void Dobrar(ref int y)
    {
        y *= 2;
        Console.WriteLine("\nValor do parametro Y dobrado " + y);
    }
}