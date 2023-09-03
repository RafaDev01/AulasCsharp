// See https://aka.ms/new-console-template for more information
Console.WriteLine("## Nullable Types ##\n");

Nullable<int> valor = 150;
Console.WriteLine(valor);

valor = null;
Console.WriteLine("vazio ali -> ", valor);

//Nullable simplificado
bool? b = null;
Console.WriteLine(b);

Console.ReadKey();
