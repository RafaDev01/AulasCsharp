Console.WriteLine("Tipo anônimo 2");

var alunos = new[]{
    new { Id = 1, Nome = "Maria", Email = "maria@email.com" },
    new { Id = 2, Nome = "Sonia", Email = "Sonia@email.com" },
    new { Id = 3, Nome = "Bruno", Email = "bruno@email.com" }
};

Console.WriteLine(alunos[0].Nome);
Console.WriteLine(alunos[0].Email);

Console.ReadKey();