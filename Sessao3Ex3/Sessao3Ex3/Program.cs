Console.WriteLine("tabela");

while(true)
{
    Console.WriteLine("Informe um número");
    int numero = Convert.ToInt32(Console.ReadLine());

    if (numero == 9999)
    {
        break;
    }

    if (numero <= 0)
    {
        Console.WriteLine("O numero digitado precisa ser maior que zero");
    }
    else if(numero > 0) 
    {
        for(int i = 0; i <= 10; i++)
        {
            Console.WriteLine($"{numero} x {i} = {numero * i}");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Fim do processamento");