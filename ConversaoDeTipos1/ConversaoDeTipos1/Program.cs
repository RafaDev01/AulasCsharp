Console.WriteLine("## Conversão de tipos\n ##");

int varInt = 100;   //4 bytes
double varDouble = varInt; //8 bytes

Console.WriteLine(varDouble);

int numeroInt = 2145678;
long numeroLong = numeroInt;
float numeroFloat = numeroLong;
double numeroDouble = numeroFloat;
decimal numeroDecimal = numeroLong;

Console.WriteLine(numeroInt);
Console.WriteLine(numeroLong);
Console.WriteLine(numeroFloat);
Console.WriteLine(numeroDouble);
Console.WriteLine(numeroDecimal);

Console.ReadLine();