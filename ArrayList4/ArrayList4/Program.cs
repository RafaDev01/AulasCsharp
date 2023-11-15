using System.Collections;

Console.WriteLine("ArrayList part4");

var lista = new ArrayList() { "Ana", 5, true, " ", null, 1.1, "Zé", 3, 9, 0 };

lista.Remove("Zé");

lista.RemoveAt(4);

lista.RemoveRange(1,2);

Console.ReadKey();