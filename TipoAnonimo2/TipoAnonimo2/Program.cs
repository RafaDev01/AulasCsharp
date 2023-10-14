Console.WriteLine("Tipo anônimo 2");

var aluno = new
{
    Id = 1,
    Nome = "Rafael",
    Email = "rflwwe123@hotmail.com",
    Endereco = new { Id = 1, Cidade = "São Paulo", Pais = "Brasil" }
};

Console.WriteLine(aluno.Nome);
Console.WriteLine(aluno.Endereco.Cidade);

Console.ReadKey();