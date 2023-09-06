Console.WriteLine("Precedencia");

bool b = !(9 != 8) && 5 >= 7 || 8 >= 6;
Console.WriteLine(b);

b = !(9 != 8) && (5 >= 7 || 8 >= 6);
Console.WriteLine(b);

Console.ReadKey();