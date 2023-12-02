﻿var limiteCredito = new List<Limite>();

for (int i = 1; i < 16; i++)
{
    limiteCredito.Add(new Limite() { Numero = i });
}

var limitesComRestricao = limiteCredito.Where(x => x.AnalisaLimite());

var primeiroLimiteComRestrição = limitesComRestricao.FirstOrDefault();
Console.WriteLine($"\n## {primeiroLimiteComRestrição.Numero}");



Console.WriteLine("\nFim do processamento");

Console.ReadKey();

public class Limite
{
    public int Numero { get; set; }
    private bool isRestricao;

    public Limite()
    {
        var semente = Guid.NewGuid().GetHashCode();
        var numeroAleatorio = new Random(semente).Next(1, 4);
        isRestricao = numeroAleatorio == 1;
    }

    public bool AnalisaLimite()
    {
        Console.WriteLine($"Executa análise de limite de crédito para o limite {Numero}");
        return isRestricao;
    }
}