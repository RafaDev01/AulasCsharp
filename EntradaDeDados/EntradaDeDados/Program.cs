Console.WriteLine(" ## Entrada de dados ##\n");

Console.WriteLine("Informe o seu nome:");
string nome = Console.ReadLine();

Console.WriteLine("\nInforme a sua idade:");
int idade = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"A sua idade é {idade} anos, e seu nome é {nome}") ;

Console.ReadKey();