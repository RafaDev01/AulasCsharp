Console.WriteLine("Calculadora de inteiros");

do
{
    Console.WriteLine("Informe o primeiro número");
    int num1 = Convert.ToInt32(Console.ReadLine());

    string operador;

    bool operadorIncorreto = true;
    do
    {
        Console.WriteLine("\nInforme o operando (+,-,*,/)");
        operador = Console.ReadLine();

        switch (operador)
        {
            case "+":
            case "-":
            case "/":
            case "*":
                operadorIncorreto = false;
                break;

            default:
                Console.WriteLine("\nINFORME UM OPERADOR VÁLIDO");
                break;
        }

    } while (operadorIncorreto);

    Console.WriteLine("\nInforme o segundo número");
    int num2 = Convert.ToInt32(Console.ReadLine());

    switch (operador)
    {
        case "+":
            Console.WriteLine($"{num1} + {num2} = {num1 + num2} \n");
            break;

        case "-":
            Console.WriteLine($"{num1} - {num2} = {num1 - num2} \n");
            break;

        case "/":
            if (num1 == 0 || num2 == 0)
                Console.WriteLine("Impossível dividir por ZERO \n");
            else
            {
                Console.WriteLine($"{num1} / {num2} = {num1 / num2} \n");
            }
            break;

        case "*":
            Console.WriteLine($"{num1} x {num2} = {num1 * num2} \n");
            break;
    }
    Console.WriteLine("Quer fazer outra operação (n) para sair");
    char resposta = Convert.ToChar(Console.ReadLine());

    if (resposta == 'n')
    {
        Console.WriteLine("\nPrograma finalizado");
        break;
    }

} while (true);