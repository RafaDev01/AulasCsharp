//declarar uma coleção do tipo List<T>

List<double> lista = new();

List<string> nomes = new();
nomes.Add("Paulo");
nomes.Add("Maria");
nomes.Add("Rafael");

var lista2 = new List<string>()
{ 
    "Paulo", "Maria", "Bia", "Pedro", "Sabotage"
};

Console.ReadKey();