Console.WriteLine("## Construtor ##");

Aluno aluno = new Aluno("Maria");

Console.WriteLine(aluno.Idade);

Console.ReadLine();

public class Aluno
{
    public Aluno(string nome)=> Nome = nome;

    public Aluno(string nome, int idade, string sexo, string aprovado) : this(nome)
    {
        Idade = idade;
        Sexo = sexo;
        Aprovado = aprovado;

    }

    public string? Nome;
    public int Idade;
    public string? Sexo;
    public string? Aprovado;
}