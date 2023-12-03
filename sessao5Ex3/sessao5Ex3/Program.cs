int numeroDeGrupos = 2;
int alunosPorGrupo = 5;
float[,] notas = new float[numeroDeGrupos, alunosPorGrupo];

Console.WriteLine("\nInforme os valores das notas:\n");

for (int i = 0; i < numeroDeGrupos; i++)
{
    Console.WriteLine($"\nAlunos do grupo{i+1}");
    for (int j = 0; j < alunosPorGrupo; j++)
    {
        notas[i, j] = Convert.ToSingle(Console.ReadLine());
    }
}

Console.WriteLine();

float mediaNotasGp1 = 0.0f;
float mediaNotasGp2 = 0.0f;

for (int i = 0; i < numeroDeGrupos; i++)
{
    float valorNotas = 0.0f;
    for (int j = 0; j < alunosPorGrupo; j++)
    {
        valorNotas += notas[i, j];
    }
    if(i == 0)
    {
        mediaNotasGp1 = valorNotas / 5;
    }
    else
    {
        mediaNotasGp2 = valorNotas / 5;
    }
}

Console.WriteLine($"Média notas grupo1: {mediaNotasGp1}");
Console.WriteLine($"Média notas grupo2: {mediaNotasGp2}");

Console.ReadKey();