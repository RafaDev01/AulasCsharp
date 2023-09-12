//não pode usar break nesse ex

var resposta = "";

do 
{
    Console.WriteLine("Qual instrucão para sair de um loop");
    Console.WriteLine("(a) quit");
    Console.WriteLine("(b) continue");
    Console.WriteLine("(c) break");
    Console.WriteLine("(d) exit\n");
    Console.WriteLine("Digite (\"x\") para sair");

    resposta = Console.ReadLine().ToLower();

    if(resposta == "a" || resposta == "b" || resposta == "d")
    {
        Console.WriteLine("Resposta incorreta!\n\n\n\n\n");
    }
    else if(resposta == "c")
    {
        Console.WriteLine("Parabéns você acertou\n\n\n\n\n");
    }
    else if (resposta == "x")
    {
        Console.WriteLine("Você saiu do programa");
    }
    else
    {
        Console.WriteLine("Opção invalida\n\n\n\n\n");
    }

    Task timer = Task.Run(async delegate {
        await Task.Delay(1500);
    });

    Console.WriteLine("Carregando...");
    timer.Wait();
    Console.Clear();
}
while (resposta != "x");
