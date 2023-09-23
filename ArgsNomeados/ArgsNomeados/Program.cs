Console.WriteLine("Argumentos nomeados");

Email email = new();

email.Enviar(destino: "rflwwe123@hotmail.com", assunto: "reunião de orçamento", titulo: "ORÇAMENTO");

Console.ReadKey();

public class Email
{
    public void Enviar(string destino, string titulo, string assunto)
    {
        Console.WriteLine($"\nPara{destino} - {titulo} \n Assunto: {assunto}");
    }
}