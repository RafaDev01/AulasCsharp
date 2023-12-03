using sessao5Ex4;
using System.Collections;

ArrayList pessoas = new ArrayList();

for (int i = 0; i < 3; i++)
{
    string nome;
    int idade;

    Console.WriteLine("Digite o nome da pessoa");
    nome = Console.ReadLine();
    Console.WriteLine("Digite a idade da pessoa");
    idade = Convert.ToInt32(Console.ReadLine());
    Pessoa p1 = new Pessoa();
    p1.Nome = nome;
    p1.Idade = idade;
    pessoas.Add(p1);
}

ExibirTodasPessoas(pessoas);

Pessoa p3 = new();
p3.Nome = "Jaime";
p3.Idade = 20;

Pessoa p2 = new();
p2.Nome = "Tania";
p2.Idade = 18;

pessoas.Add(p3);
pessoas.Add(p2);

Console.WriteLine("\nExibindo pessoas com mais duas incluidas");
ExibirTodasPessoas(pessoas);

pessoas.RemoveAt(pessoas.Count - 1);

Console.WriteLine("\nExibindo pessoas sem o ultimo elemento");
ExibirTodasPessoas(pessoas);


Console.ReadKey();

static void ExibirTodasPessoas(ArrayList pessoas)
{
    foreach (Pessoa i in pessoas)
    {
        Console.WriteLine(i.Exibir());
    }
}