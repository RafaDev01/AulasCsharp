Console.WriteLine("Ex com arrays");

Console.WriteLine("Digite o tamnho do array");
int tamanhoArray = Convert.ToInt32(Console.ReadLine());

int[] ints = new int[tamanhoArray];

for (int i = 0; i < ints.Length; i++)
{
    Console.WriteLine("\nDigite um numero para adicionar ao array\n");
    ints[i] = Convert.ToInt32(Console.ReadLine());
}

string numero;

Console.WriteLine("\nInforme o número a localizar no array (tecle fim para sair) :\n");
do
{
    numero = Console.ReadLine();
    if(numero != "fim")
    {
        int valor = Convert.ToInt32(numero);

        if(Array.BinarySearch(ints, valor) > 0)
        {
            Console.WriteLine($"\nO número {numero} existe no array");
        }
        else
        {
            Console.WriteLine($"\nO número {numero} NAO existe no array");
        }
    }

}while (numero != "fim");


Console.ReadKey();