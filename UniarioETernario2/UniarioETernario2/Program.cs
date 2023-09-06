Console.WriteLine("Uniário e ternário");

Console.WriteLine("Informe o valor de x: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe o valor de y: ");
int y = Convert.ToInt32(Console.ReadLine());

string resultado = x > y ? "x é maior que y" :
                   x < y ? "x é menor que y" :
                   x == y ? "x é igual a y" : "Sem resultado";

Console.WriteLine(resultado);

Console.ReadKey();