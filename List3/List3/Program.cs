var lista = new List<string>() { "maria", "Pedro", "Ana" };

string[] array1 = { "Diná", "Carlos", "Pedro" };

lista.AddRange(array1);

lista.InsertRange(1, array1);

Console.WriteLine(lista.Count + " itens ");

Console.ReadKey();