Console.WriteLine("While");

int numero = 0;

Console.WriteLine("Digite um número maior que zero para ver a tabuada");

while(numero <= 0)
{
    numero = Convert.ToInt32(Console.ReadLine());
    int i = 0;

    if (numero > 0)
    {
        while (i <= 10)
        {
            Console.WriteLine($"{numero} x {i} = {numero * i}");
            i++;
        }
    }
    else
    {
        Console.WriteLine("Digite um numero maior que zero");
    }

}

Console.WriteLine("Fim do processamento");