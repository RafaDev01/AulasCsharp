Console.WriteLine("Sobrecarga");

Email email = new();

email.Enviar("Emrepsa.com.br");
email.Enviar("Emrepsa.com.br","Proposta com");
email.Enviar("Emrepsa.com.br", 2000);
email.Enviar(2000,"Emrepsa.com.br");

Console.ReadKey();

public class Email
{
    public void Enviar(string endereco)
    {
        Console.WriteLine($"{endereco}");
        Console.WriteLine($"Assunto padrãao");
    }

    public void Enviar(string endereco, string assunto)
    {
        Console.WriteLine($"{endereco}");
        Console.WriteLine($"{assunto}");
    }

    public void Enviar(string endereco, decimal valor)
    {
        Console.WriteLine($"{endereco}");
        Console.WriteLine("Proposta comercial");
        Console.WriteLine($"{valor}");
    }

    public void Enviar(decimal valor, string endereco)
    {
        Console.WriteLine($"{endereco}");
        Console.WriteLine("Pagamento fornecedor");
        Console.WriteLine($"{valor}");
    }
}

