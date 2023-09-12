int f = 1;
int num;

Console.WriteLine("Calculo fatorial");

Console.WriteLine("\nInforme um número:");
num = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= num; i++)
{
    f = f * i;
}

Console.WriteLine(f);