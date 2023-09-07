Console.WriteLine("Digite o primeiro numero");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o segundo numero");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o terceiro numero");
int num3 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"primeiro numero: {num1}\nSegundo numero: {num2}\nterceiro número: {num3}\n");

string resultado = "O maior numero é: ";

if(num1 > num2 && num1 > num3)
{
    Console.WriteLine($"{resultado} {num1}");
}
else if(num2 > num3)
{
    Console.WriteLine($"{resultado} {num2}");
}
else
{
    Console.WriteLine($"{resultado} {num3}");
}