Object carroObj = new Carro();

var x = carroObj as string;

if(x != null)
{
    Console.WriteLine("Converteu obj para string");
}
else
{
    Console.WriteLine("Não foi possivel converter, x é null");
}

Console.ReadKey();

class Carro { }