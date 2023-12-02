Console.WriteLine("Exercícios com List<T>");

var alunos = new List<Aluno>();

var nomes = new List<string>() {
    "Maria", "Manoel", "Amanda", "Carlos", "Jaime", "Debora", "Alicia", "Sandra", "Marta", "Sueli"
};

var notas = new List<double>() {
    8.75, 6.95, 7.25, 7.25, 8.50, 5.95, 9.25, 5.55, 7.85, 9.15
};

for(int i = 0; i < nomes.Count; i++)
{
    alunos.Add(new Aluno(nomes[i], notas[i]));
}

foreach(var aluno in alunos)
{
    Console.WriteLine($"Aluno: {aluno.Nome} - Nota: {aluno.Nota}");
}

Console.WriteLine(Aluno.MediaNotas(alunos));

alunos.Add(new Aluno("Bia", 7.75));
alunos.Add(new Aluno("Mario", 8.95));

Console.WriteLine();
Console.WriteLine();
foreach (var aluno in alunos)
{
    Console.WriteLine($"Aluno: {aluno.Nome} - Nota: {aluno.Nota}");
}
Console.WriteLine($"{Aluno.MediaNotas(alunos)}\n");

int index = alunos.FindIndex(aluno => aluno.Nome == "Amanda");
alunos.RemoveAt(index);

Console.WriteLine();
Console.WriteLine();



alunos.Sort((a1, a2) => string.Compare(a1.Nome, a2.Nome, StringComparison.Ordinal));
foreach (var aluno in alunos)
{
    Console.WriteLine($"Aluno: {aluno.Nome} - Nota: {aluno.Nota}");
}

Console.WriteLine();
Console.WriteLine();
Console.WriteLine();

foreach (var aluno in alunos)
{
    if(aluno.Nota >= 8)
    {
        Console.WriteLine($"Aluno: {aluno.Nome} - Nota: {aluno.Nota}");
    }
}


Console.ReadKey();

public class Aluno
{
    public Aluno(string nome, double nota)
    {
        Nome = nome;
        Nota = nota;
    }

    public string Nome { get; set; }
    public double Nota { get; set; }

    static public string MediaNotas(List<Aluno> alunos)
    {
        double media = 0.0;
        string mediaEQuantidadeAlunos = "";

        foreach (var aluno in alunos)
        {
            media += aluno.Nota;
        }
        media = media / alunos.Count;

        mediaEQuantidadeAlunos = $"Média: {media.ToString("F2")}, quant:{alunos.Count}";    

        return mediaEQuantidadeAlunos;
    }
}