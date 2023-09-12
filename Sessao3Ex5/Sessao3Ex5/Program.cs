Console.WriteLine("Exibindo números pares exceto o num 16:\n");
Console.WriteLine("Incrementando em 2:");

int numeros = 0;

while (numeros <= 20)
{
   

    if (numeros % 2 == 0)
    {
        if (numeros != 16)
        {
            Console.WriteLine($"{numeros}");
        }
    }
    numeros += 2;
}

Console.WriteLine("\n\n==========================================\n\n\n");
Console.WriteLine("incrementando 1");
numeros = 0;

while (numeros <= 20)
{
    if (numeros % 2 == 0)
    {
        if (numeros != 16)
        {
            Console.WriteLine($"{numeros}");
        }
    }
    numeros++;
}

Console.WriteLine("\n\n==========================================\n\n\n");
Console.WriteLine("condicao para acabar");
numeros = 0;

while (true)
{
    if (numeros > 20)
        break;

    if (numeros % 2 == 0)
    {
        if (numeros == 16)
        {
            numeros++;
            continue;
        }    
        Console.WriteLine($"{numeros}");   
    }
    numeros++;
}
