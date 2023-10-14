Console.WriteLine("\nSoma de números inteiros\n");

//passando os valores
int[] valores = { 1, 2, 3, 10 };

var resultado = Calcular.Soma(valores);
Console.WriteLine(resultado);

//passando os valores
var resultado2 = Calcular.Soma(new int[] { 10,20,30 });

Console.WriteLine(resultado2);

Console.ReadKey();

public class Calcular
{
    public static int Soma(int[] numeros)
    {
        int total = 0;
        foreach (int numero in numeros)
        {
            total += numero;
        }
        return total;
    }
}