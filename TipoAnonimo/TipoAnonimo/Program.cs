Console.WriteLine("Tipo anônimo");

var aluno = new
{
    Nome = "Rafael",
    Idade = 24
};

//aluno.Nome = "Rafaeeel"; -> erro, prorpiedades do tipo anonimo são somente leitura

Console.WriteLine(aluno.GetType().ToString());

Console.WriteLine($"{aluno.Nome} tem {aluno.Idade} anos");

Console.ReadKey();