Console.WriteLine("Switch 4");

int cargo = 0;
int funcao = 0;

Console.WriteLine("Você é gerente(1) ou programador(2) ?\t");
cargo = Convert.ToInt32(Console.ReadLine());

if(cargo == 2)
{
    Console.WriteLine("Você é Junior(1) ou Senior(2)? \t");
    funcao = Convert.ToInt32(Console.ReadLine());
}

switch(cargo)
{
    case 1:
        Console.WriteLine("\nBem-Vindo Gerente.");
        break;
    case 2:
        Console.WriteLine("\nBem vindo Programador.");
        switch(funcao)
        {
            case 1:
                Console.WriteLine("\nVocê é junior.");
                break;
            
            case 2:
                Console.WriteLine("\nVocê é Senior.");
                break;
            default:
                Console.WriteLine("\nFunção desconhecida");
                break;
        }
        break;
    default:
        Console.WriteLine("\nNão consegui te identificar");
    break;
}

Console.WriteLine("Fim do processamento");
Console.ReadKey();