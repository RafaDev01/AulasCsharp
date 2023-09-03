int? a = null;

//if a==null então atribuirá o valor da direita
//?? -> operador de coalescência nula
int b = a ?? 0;

a = 10;

Console.WriteLine(b);

int? x = 4;
int? y = 3;
int? z = x * y;

Console.WriteLine(z);

if(a.HasValue)
{
    Console.WriteLine($"A = {a.Value}");
}
else
{
    Console.WriteLine("A não possui um valor");
}



Console.ReadKey();