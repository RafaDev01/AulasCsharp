Console.WriteLine("Solucao do professor");

string[,] alunos = new string[2, 5];

for (int i = 0; i < alunos.GetLength(0); i++)
{
    for (int j = 0; j < alunos.GetLength(1); j++)
    {
        Console.WriteLine($"Informe o valor para o elemento na posição: [{i},{j}]");
        alunos[i, j] = Console.ReadLine();
    }
}

for (int i = 0; i < alunos.GetLength(0); i++)
{
    for (int j = 0; j < alunos.GetLength(1); j++)
    {
        Console.Write($"[{i},{j}] = {alunos[i,j]}\t");
    }
    Console.WriteLine();
}

Console.ReadKey();