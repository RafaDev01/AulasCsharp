using Sessao5Ex5;

List<Produto> produtos = new List<Produto>() { 
    new Produto { Nome = "Clips", Preco = 3.95m},
    new Produto { Nome = "Caneta", Preco = 5.99m},
    new Produto { Nome = "Lápis", Preco = 4.15m},
    new Produto { Nome = "Estojo", Preco = 6.99m},
    new Produto { Nome = "Caderno", Preco = 7.55m}
};

produtos.Add(new Produto { Nome = "Mochila", Preco = 22.44m });

produtos.Sort((a, b) => a.Nome.CompareTo(b.Nome));

List<Produto> produtosComPrecoMenorQue5 = produtos.Where(p => p.Preco < 5).ToList();

Console.WriteLine(produtos.FindIndex(p => p.Nome == "Estojo"));

ExibirInformacoes(produtosComPrecoMenorQue5);
Console.WriteLine();
ExibirInformacoes(produtos);


Console.ReadKey();

void ExibirInformacoes(List<Produto> listaDeProdutos)
{
    int totalProdutos = listaDeProdutos.Count;
    decimal valorTotal = 0.0m;
    decimal media = 0.0m;

    foreach(Produto p in listaDeProdutos)
    {
        Console.WriteLine($"{p.Nome } : R${p.Preco}");
        valorTotal += p.Preco;
    }
    media = valorTotal / totalProdutos;



    Console.WriteLine($"\nValor total dos produtos: {valorTotal:F2}" +
        $"\nMédia de valor dos produtos: {media:F2}" +
        $"\nQuantidade de produtos: {totalProdutos}"
        );
}

