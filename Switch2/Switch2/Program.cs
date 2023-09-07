Console.WriteLine("Switch");

Console.WriteLine("Informe um número inteiro:");
int numero = Convert.ToInt32(Console.ReadLine());

switch(numero % 2)
{
    case 0:
        Console.WriteLine($"\no número é par");
        break;

    case 1:
        Console.WriteLine($"\no número é impar");
        break;
}

Console.WriteLine("Fim do processamento...");
Console.ReadKey();