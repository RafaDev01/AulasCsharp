Console.WriteLine("Tabuada do 2 ao 6 usando do while");

int i = 1;
do
{
    int multiplicador = 1;
    do
    {
        Console.WriteLine($"{i} x {multiplicador} = {i*multiplicador}");
        multiplicador++;
    }while( multiplicador <= 10 );

    Console.WriteLine();
    i++;
} while (i <= 6);