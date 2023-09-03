// See https://aka.ms/new-console-template for more information
using System.Data;

Console.WriteLine("## Struct DateTime ##\n");

DateTime dataAtual = DateTime.Now;

//Criar data especifica usa formato: aaaa,mm,dd
DateTime dataHoje = new DateTime(2023,12,06);
Console.WriteLine(dataHoje.Year);

//definir as horas
DateTime dataHoraHoje = new DateTime(2023, 12, 06, 21, 10, 30);
Console.WriteLine(dataHoraHoje.ToShortTimeString());

//adicionando valores
Console.WriteLine(dataAtual.AddDays(30));
Console.WriteLine(dataAtual.AddYears(1000));

Console.ReadKey();
