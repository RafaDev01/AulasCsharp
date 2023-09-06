Console.WriteLine("Inferencia de tipos\n");

var idade = 25;
var nome = "Maria";
var salario = 2500.00m;

idade += 30;

Console.WriteLine($"{nome} tem {idade} anos e ganha {salario.ToString("c")}");

var teste = new Teste();
teste.MeuMetodo();

class Teste
{
    public void MeuMetodo()
    {
        Console.WriteLine("Meu método");
    }
}