Console.WriteLine("Minha solução");

string[,] alunos = new string[2,5];

for(int i = 0; i < alunos.GetLength(0); i++)
{
    for(int j = 0; j < alunos.GetLength(1); j++)
    {
        Console.WriteLine($"\nDigite o nome do aluno[{i},{j}]");
        alunos[i, j] = Console.ReadLine();
    }
}

Console.WriteLine("\nNome dos alunos e suas posições:\n");

for (int i = 0; i < alunos.GetLength(0); i++)
{
    for (int j = 0; j < alunos.GetLength(1); j++)
    {
        Console.Write($"[{i},{j}]{alunos[i,j]} ,");
    }
    Console.WriteLine();
}

Console.ReadKey();
