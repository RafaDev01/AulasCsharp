using Enumerations;

Console.WriteLine("## Enum ##");

Console.WriteLine($"{Categorias.Moda} - {(int)Categorias.Moda}");
Console.WriteLine($"{Categorias.Automotivo} - {(int)Categorias.Automotivo}");
Console.WriteLine($"{Categorias.Artes} - {(int)Categorias.Artes}");
Console.WriteLine($"{Categorias.Bebidas} - {(int)Categorias.Bebidas}");
Console.WriteLine($"{Categorias.Livros} - {(int)Categorias.Livros}");
Console.WriteLine($"{Categorias.Brinquedos} - {(int)Categorias.Brinquedos}");

Console.WriteLine("\nSelecione a Categoria teclando o seu valor");
int valor = Convert.ToInt32( Console.ReadLine());

var nomeMembroDaEnum = (Categorias)valor;

Console.WriteLine($"Voçê escolheu {nomeMembroDaEnum.ToString()}");

Console.ReadKey();
