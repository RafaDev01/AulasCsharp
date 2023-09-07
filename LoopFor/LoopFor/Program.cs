int resultado, numero;

Console.WriteLine("Informe um número inteiro para ver a tabuada: ");
numero = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i <= 10; i++)
{
    resultado = numero * i;
    Console.WriteLine($"{numero} x {i} = {resultado}");
}

Console.WriteLine("Fim do processamento...");
Console.ReadKey();