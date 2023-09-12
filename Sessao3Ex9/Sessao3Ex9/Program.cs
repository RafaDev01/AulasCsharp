Console.WriteLine("Digite a nota do aluino (de 1 a 10) ou digite (\"999\") para sair");




while(true)
{
    int nota = Convert.ToInt32(Console.ReadLine());
    if (nota == 999)
    {
        Console.WriteLine("Saindo...");
        break;
    }
    if(nota < 0 || nota > 10)
    {
        Console.WriteLine("Nota invalida digite novamente");
    }

    switch (nota)
    {
        case 10:
            Console.WriteLine("Nota A+");
            break;

        case 9:
            Console.WriteLine("Nota A");
            break;

        case 8:
        case 7:
            Console.WriteLine("Nota B");
            break;

        case 6:
            Console.WriteLine("Nota C");
            break;
        
        case 5:
            Console.WriteLine("Nota E");
            break;

        case 4:
        case 3:
        case 2:
        case 1:
        case 0:
            Console.WriteLine("Nota F");
            break;
    }
}