using HerancaEx1;

ContaCorrente c1 = new(0001, "Rafael");
ContaPoupanca contaPupanca1 = new(0002, "Murilo Afonso");
ContaInvestimento contaInvestimento = new(0003, "Gabriel");

c1.Depositar(1000);
c1.Sacar(100);
c1.ExibirDetalhes();

contaPupanca1.Depositar(1000);
contaPupanca1.Sacar(100);
contaPupanca1.ExibirDetalhes();

contaInvestimento.Depositar(1000);
contaInvestimento.Sacar(100);
contaInvestimento.ExibirDetalhes();

c1.Sacar(2000);
c1.ExibirDetalhes();

contaPupanca1.Sacar(2000);
contaPupanca1.ExibirDetalhes();

contaInvestimento.Sacar(2000);
contaInvestimento.ExibirDetalhes();


Console.ReadKey();