Console.WriteLine("Do while");

var i = 1;

do
{
    Console.WriteLine($"i={i}");
    i++;
    if (i > 7)
    {
        break;
    }
}
while (i < 10);