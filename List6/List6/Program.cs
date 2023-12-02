var lista = new List<string>() { "Maria", "Ana", "Marcos", "Pedro", "Zé", "Zilda", "Lula", "Bolsonaro" };

var res1 = lista.Contains("Ana");
var res2 = lista.Contains("Zé");

var res3 = lista.Contains("Ze");
var res4 = lista.Contains("Nathan");

ExibirLista(lista);

lista.Sort();

ExibirLista(lista);

lista.Clear();

Console.WriteLine(lista.Count + " itens");
ExibirLista(lista);

Console.WriteLine("FIM");

Console.ReadKey();

static void ExibirLista(List<string> lista)
{
    Console.WriteLine();
    foreach (var item in lista)
        Console.WriteLine(item);
}