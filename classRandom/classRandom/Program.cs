
Random random = new Random();

byte[] randBytes = new byte[10];

random.NextBytes(randBytes);

for (int i = 0; i < 6; i++)
{
    Console.WriteLine(randBytes[i]);
}
Console.ReadKey();