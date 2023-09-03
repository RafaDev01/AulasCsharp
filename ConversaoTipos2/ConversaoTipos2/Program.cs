Console.WriteLine("## Conversão de tipos explicita ##\n");

double varDouble = 12.456; //8 bytes
int varInt = (int)varDouble; //4 bytes (perda de precisão)

int num1 = 10;
int num2 = 4;
Console.WriteLine(varInt);  //não suporte casas decimais

//precisa converter para dar o resultado certo
float resultado = (float) num1 / num2; //resultado certo 2.5
Console.WriteLine(resultado);

Console.ReadLine();