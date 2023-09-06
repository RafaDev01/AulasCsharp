Console.WriteLine("Calculando o perímetro de um círculo com constantes");

double raio, perimetro, area;
const double PI = Math.PI;

Console.WriteLine("Informe o raio do circulo : ");
raio = Convert.ToDouble(Console.ReadLine());

perimetro = 2 * PI * raio;
area = PI * Math.Pow(raio, 2);

Console.WriteLine(perimetro);
Console.WriteLine(area);

Console.ReadKey();