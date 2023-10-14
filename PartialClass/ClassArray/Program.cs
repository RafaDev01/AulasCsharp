Console.WriteLine("Classe array");

string[] nomes = { "Ana", "Maria", "Dinair", "Paulo", "Carlos", "Beatriz" };

Console.WriteLine("\n\nExibindo o array original...");
ExibeArray(nomes);

Console.WriteLine("\n\nInvertendo a ordem do array...");
Array.Reverse(nomes);
ExibeArray(nomes);

Console.WriteLine("\n\nOrdenando o Array...");
Array.Sort(nomes);
ExibeArray(nomes);

Console.WriteLine("\n\nLocalizando um item no array Array...");
Console.WriteLine("Informe o nome");
string? nome = Console.ReadLine();

var indice = Array.BinarySearch(nomes, nome);

if(indice >= 0)
{
    Console.WriteLine($"\n{nome} foi encontrado com índice = {indice}");
}else
    Console.WriteLine($"\n{nome} Não foi encontrado");

Console.ReadKey();

static void ExibeArray(string[] nomes)
{
    foreach (string nome in nomes)
    {
        Console.WriteLine($"{nome} ");
    }
}