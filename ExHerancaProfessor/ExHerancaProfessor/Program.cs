using ExHerancaProfessor;

Console.WriteLine("\nConta corrente");
Conta conta = new();
conta.Numero = 111;
conta.Titular = "Maria";

Console.WriteLine("Depositando R$1000,00");
conta.Depositar(1000);
Console.WriteLine("Sacando R$ 100,00");
conta.Sacar(100);
Console.WriteLine($"Saldo da conta: {conta.Saldo.ToString("c")}");

Console.ReadKey();