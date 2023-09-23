Console.WriteLine("Campos estáticos");

ContaCorrente.Juros = 4.25f;

ContaCorrente c1 = new ContaCorrente();
c1.Conta = 101;
c1.Nome = "Maria";

ContaCorrente c2 = new ContaCorrente();
c2.Conta = 102;
c2.Nome = "Marta";

Console.WriteLine($"Cliente : {c1.Nome} - Juros Anual : {c1.JurusAnual()}");
Console.WriteLine($"Cliente : {c2.Nome} - Juros Anual : {c2.JurusAnual()}");

Console.ReadKey();

public class ContaCorrente
{
    public int Conta;
    public string? Nome;
    public static float Juros;

    public float JurusAnual()
    {
        return Juros * 12;
    }
}