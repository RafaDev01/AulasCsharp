Console.WriteLine("Construtor estático");

//Invoca o contrutor parametrizado e o statico
Pessoa p1 = new(19, "Maria");

Console.WriteLine(p1.Nome + " - " + p1.Idade);
Console.WriteLine("\nIdade mínima " + Pessoa.IdadeMinima + "\n");

//invoca somente o contrutor parametrizado, porque o estático é invocado somente uma vez
Pessoa p2 = new(20, "Manoel");

Console.WriteLine(p2.Nome + " - " + p2.Idade);
Console.WriteLine("\nIdade mínima " + Pessoa.IdadeMinima);

Console.ReadKey();
