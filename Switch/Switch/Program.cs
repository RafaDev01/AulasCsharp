Console.WriteLine("Switch");

var compra = 600;

Console.WriteLine($"Valor da compra RS{compra}\n");
Console.WriteLine("Informe o numero de parcelas (1 a 3)\t");

var numeroParcelas = Convert.ToInt32(Console.ReadLine());

switch(numeroParcelas)
{
    case 1:
        Console.WriteLine($"\n Prestação R${compra/numeroParcelas}");
    break;

    case 2:
        Console.WriteLine($"\n Prestação R${compra / numeroParcelas}");
    break;

    case 3:
        Console.WriteLine($"\n Prestação R${compra / numeroParcelas}");
    break;

    default:
        Console.WriteLine("Valor invalido, informe 1,2 ou 3");
    break;
}

Console.WriteLine("\n Fim do precessamento...");

Console.ReadLine();