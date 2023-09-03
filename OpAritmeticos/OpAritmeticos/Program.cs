Console.WriteLine("##Operadores Aritméticos \n##");

Console.WriteLine("Informe o valor de x");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe o valor de y");
int y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"\nRaiz quadrada de x = {Math.Sqrt(x)}");
Console.WriteLine($"\nPotência de x elevado a y = {Math.Pow(x,y)}");
Console.WriteLine($"\nValor mínimo entre x e y = {Math.Min(x,y)}");
Console.WriteLine($"\nValor máximo entre x e y = {Math.Max(x,y)}");
Console.WriteLine($"\nCoseno de x = {Math.Cos(x)}");
Console.WriteLine($"\nSeno de x = {Math.Sin(x)}");
Console.WriteLine($"\nExponencial de x = {Math.Exp(x)}");

//Console.WriteLine($"soma de x+y = {x + y}");
//Console.WriteLine($"substracao de de x-y = {x - y}");
//Console.WriteLine($"Multiplicação de de x*y = {x * y}");
//double divisao = (double)x/y;
//Console.WriteLine($"Divisao de de x/y = {divisao}");
//Console.WriteLine($"Módulo de de x%y = {x % y}");

Console.ReadKey();