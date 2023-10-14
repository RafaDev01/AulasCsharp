Console.WriteLine("Exercício (Minha resolução)");

string?[] nomes = new string[5];
double[] notas = new double[5];

for(int i = 0; i < nomes.Length; i++)
{
    Console.WriteLine("\nInforme o nome do aluno");
    nomes[i] = Console.ReadLine();

    Console.WriteLine($"\nInforme a nota de {nomes[i]}");
    notas[i] = Convert.ToDouble(Console.ReadLine());
}

Console.WriteLine();

for (int i = 0;i < nomes.Length;i++)
{
    Console.WriteLine($"Nome: {nomes[i]} | Nota: {notas[i]}");
}

double media = 0;

foreach (double nota in notas)
{
    media += nota;
}

Console.WriteLine($"\nMédia das notas {media / notas.Length}");