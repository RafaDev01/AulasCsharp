
var lista = new List<string>() { "Maria", "Ana", "Marcos", "Pedro"};

//acessar um elemento da lista usando indice
var primeiro = lista[0];
var ultimo = lista[lista.Count - 1];

Console.WriteLine(primeiro);
Console.WriteLine(ultimo);

Console.WriteLine("\n=======================\n");

lista[0] = "Zé";
lista[3] = "Silvia";

Console.WriteLine(lista[0]);
Console.WriteLine(lista[3]);

Console.WriteLine("\n=======================\n");

for (int i = 0; i < lista.Count; i++)
{
    Console.WriteLine(lista[i]);
}

Console.WriteLine("\n=======================\n");

foreach (var item in lista)
{
    Console.WriteLine(item);
}

Console.ReadKey();