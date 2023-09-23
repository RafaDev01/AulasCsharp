Console.WriteLine("Classe e objeto");

Pessoa p1 = new Pessoa();
p1.nome = "Rafael";
p1.idade = 24;
p1.sexo = "Masculino";

Pessoa p2 = p1;

p2.nome = "uai";

Console.WriteLine(p1.nome);
Console.WriteLine(p2.nome);

Console.ReadKey();

class Pessoa
{
    public string? nome;
    public int idade;
    public string? sexo;
}