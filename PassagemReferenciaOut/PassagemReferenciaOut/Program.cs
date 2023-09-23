Console.WriteLine("Argumentos por referencia OUT");

Console.WriteLine("Informe o raio do círculo");
double raio = Convert.ToDouble(Console.ReadLine());

Circulo circulo = new();

double perimetro = circulo.CalculaAreaPerimetro(raio, out double area);

Console.WriteLine("Perimetro da cricunferencia " + perimetro);
Console.WriteLine("Área da circunferencia " + area);

Console.ReadKey();

public class Circulo
{
    public double CalculaAreaPerimetro(double raio,out double area)
    {
        area = Math.PI * Math.Pow(raio, 2);
        double perimetro = 2 * Math.PI * raio;
        return perimetro;
    }
}