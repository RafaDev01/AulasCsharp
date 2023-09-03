Console.WriteLine("Definindo variáveis do tipo string e object e dynamic");
Console.WriteLine();

string nome = "Curso C#";
String titulo = "Curso C# Essencial";

Console.WriteLine(nome);
Console.WriteLine(titulo);

//Cada valor reatribuido ainda existirá na memória, não é aconselhavel reatribuir strings em projetos grandes
string valor = "Isto é uma string";

valor = "Isso é uma string alterada";

valor = "teste";
//Na ocasião acima é melhor usar StringBuilder

dynamic nota = 10;
dynamic valorObj = 8.55m;

object nomeObj = "Maria";
object ativa = true;
object letra = "A";

Console.WriteLine(nota);
Console.WriteLine(valorObj);
Console.WriteLine(nomeObj);
Console.WriteLine(ativa);
Console.WriteLine(letra);

Console.ReadLine();
