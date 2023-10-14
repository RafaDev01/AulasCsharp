using static System.Runtime.InteropServices.JavaScript.JSType;

Console.WriteLine("");

//declaração do array
int[] numeros;

//aloquei memória
numeros = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

//string[] nomes = new string[5] { "Maria", "Ana", "Marta", "Paulo", "Carlos" };

//string[] nomes1 = new string[] { "Maria", "Ana", "Marta", "Paulo", "Carlos" };

//sintaxe simplificada
string[] nomes = { "Maria", "Ana", "Marta", "Paulo", "Carlos" };

//Console.WriteLine(nomes[0]);
//Console.WriteLine(nomes[1]);
//Console.WriteLine(nomes[2]);
//Console.WriteLine(nomes[3]);
//Console.WriteLine(nomes[4]);

for (int i = 0; i < numeros.Length; i++) 
{
    Console.WriteLine($"Elemento no índice {i} : {numeros[i]}");
}

Console.WriteLine();

for (int i = 0; i < nomes.Length; i++)
{
    Console.WriteLine($"Elemento no índice {i} : {nomes[i]}");
}

Console.WriteLine("\nForEach\n");

foreach (int numero in numeros)
{
    Console.Write($"{numero} ");
}

Console.WriteLine();

foreach (var nome in nomes)
{
    Console.Write($"{nome}, ");
}

Console.ReadKey();  