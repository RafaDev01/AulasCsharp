Console.WriteLine("Métodos");

MinhaClasse m1 = new MinhaClasse();

m1.Saudacao();

Console.ReadKey();

class MinhaClasse
{
    public void Saudacao()
    {
        Console.WriteLine("Olá Mundo");
        ExibirDataAtual();
    }

    public void ExibirDataAtual() =>
        Console.WriteLine(DateTime.Now.ToShortDateString());

}