Console.WriteLine("List find");

List<string> frutas = new() 
{ 
    "Uva", "Banana", "Pera", "Maça", "Abacate", "Laranja", "Morango" 
};

var fruta1 = frutas.Find(Procura);
Console.WriteLine($"predicado => {fruta1}\n");

var fruta2 = frutas.Find(fruta => fruta.Contains('n'));
Console.WriteLine($"Find => {fruta2}\n");

var fruta3 = frutas.FindLast(i=> i.Contains('n'));
Console.WriteLine($"FindLast => {fruta3}\n");

var fruta4 = frutas.FindIndex(i => i.Contains('n'));
Console.WriteLine($"FindIndex => {fruta4} item = {frutas[fruta4]} \n");

var fruta5 = frutas.FindLastIndex(i => i.Contains('n'));
Console.WriteLine($"FindLastIndex => {fruta5} item = {frutas[fruta5]} \n");

var frutas6 = frutas.FindAll(i => i.Contains('n'));

Console.Write("\nFindAll :");
foreach (var item in frutas6)
{
    Console.Write($" {item}, ");
}

Console.ReadKey();

static bool Procura(string item)
{
    return item.StartsWith('B');
}