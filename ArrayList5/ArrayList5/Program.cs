using System.Collections;

var lista = new ArrayList() { "Maria", 5, true, 4.5, null, DateTime.Now };
var lista2 = new ArrayList() { "Maria", "Ana", "Zilda", "Carlos", "Diná" };

foreach (var item in lista2)
{
    Console.WriteLine($"{item}");
}

//verificar se existe um elemnto na coleção 

var res1 = lista.Contains(5);
bool res2 = lista.Contains("Mari");

Console.WriteLine(res1);
Console.WriteLine(res2);
Console.WriteLine(lista.Contains(null));

Console.WriteLine($"Número de elementos no array {lista.Count}" );

lista.Clear();
lista2.Sort();

Console.WriteLine($"Número de elementos no array depois do clear {lista.Count}");

Console.WriteLine("\nArrayList ordenado \n");

foreach (var item in lista2)
{
    Console.WriteLine($"{item}");
}

Console.ReadKey();