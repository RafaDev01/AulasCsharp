Console.WriteLine("Instrução if");

Console.WriteLine("Cliente especial? (S/N)");
var resposta = Convert.ToBoolean(Console.ReadLine());

if(resposta)
    Console.WriteLine("Desconto de 10%");

Console.WriteLine("Fim do processamento");

Console.ReadKey();