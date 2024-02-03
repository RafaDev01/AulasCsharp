using ConsoleApp1;

Quadrado quadrado = new Quadrado();

Console.WriteLine(quadrado.Descricao());

Console.WriteLine("\nInforme a cor da forma");
quadrado.Cor = Console.ReadLine();

Console.WriteLine("\nInforme o valor do lado do quadrado");
quadrado.Lado = Convert.ToInt32(Console.ReadLine());

quadrado.CalcularArea();
quadrado.CalcularPerimetro();

Console.WriteLine($"\nÁrea do quadrado : {quadrado.Area} m2");
Console.WriteLine($"\nPerimetro do quadrado : {quadrado.Perimetro} m2");

Console.WriteLine($"\nO quadrado tem a cor : {quadrado.Cor}");

Console.ReadKey();