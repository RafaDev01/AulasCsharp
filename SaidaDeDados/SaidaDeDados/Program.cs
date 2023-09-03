Console.WriteLine("Saída de dados: Formatação");
Console.WriteLine();

int idade = 25;
string nome = "Maria";
Console.Write(nome);
Console.WriteLine(idade);

//Escrever na mesma linha a 'Maria tem 25 anos'
Console.Write(nome);
Console.Write(" tem ");
Console.Write(idade);
Console.Write( " anos");
Console.WriteLine();

//usar a concatenação : usando operador +

Console.WriteLine(nome + " tem " + idade + " anos");

//usar placeholder : usa numeração com início em zero
Console.WriteLine("{0} tem {1} anos, placeholder", nome, idade);

//usar a interpolação de strings :$ -> a interpoção {}
Console.WriteLine($"{nome} tem {idade}, anos interpolado");

Console.ReadLine();