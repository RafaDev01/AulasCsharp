using System.Collections;

Console.WriteLine("ArrayList");

ArrayList lista = new();

lista.Add("Paulo");
lista.Add(25.5);
lista.Add(null);

var lista2 = new ArrayList() { "Paulo", 25.5, null };

lista2.Add("Sharp");

foreach (var element in lista2)
{
    Console.WriteLine(element);
}



Console.ReadKey();