Console.WriteLine("Ex com array");

string[] frutas = new string[]
{
    "Maça", "Banana", "Laranja", "Uva", "Manga", "Pêra", "Abacate", "Mamão", "Pêssego", "Amora"
};

MostrarFrutasFor(frutas);

Console.WriteLine($"\nSegunda fruta: {frutas[1]}, penultima fruta: {frutas[frutas.Length-2]}\n");

frutas[2] = "Kiwi";
frutas[frutas.Length-1] = "Caqui";

MostrasFrutasForEach(frutas);

Console.WriteLine("\nFrutas organizadas:");
Array.Sort(frutas);
MostrasFrutasForEach(frutas);

Console.WriteLine("\nFrutas reverse:");
Array.Reverse(frutas);

MostrasFrutasForEach(frutas);

Console.ReadKey();

static void MostrarFrutasFor(string[] frutas)
{
    Console.WriteLine("\nMostrando dados com laço for\n");
    for (int i = 0; i < frutas.Length; i++)
    {
        Console.WriteLine($"{frutas[i]}");
    }
    Console.WriteLine($"Total de frutas: {frutas.Length}");
}

static void MostrasFrutasForEach(string[] frutas)
{
    Console.WriteLine("\nMostrando frutas forEach\n");
    foreach (string frut in frutas)
    {
        Console.WriteLine(frut);
    }
}