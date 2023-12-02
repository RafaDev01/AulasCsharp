var lista = new List<int>() { 9, 5, 4, 1, 7, 8, 3, 6, 9, 0 };

lista.Remove(7);

lista.RemoveAt(4);

lista.RemoveRange(0, 2);

Console.WriteLine(lista.Count + " itens");

Console.ReadKey();