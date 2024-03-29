﻿var gato = new Gato() { Nome = "bichano" };
gato.ExibeNome();

var cao = new Cachorro() { Nome = "pipoca" };
cao.ExibeNome();

Console.ReadKey();

//classe base
class Animal
{
    public string? Nome { get; set; }
    public virtual void ExibeNome()
    {
        Console.WriteLine($"Meu nome é {Nome}");
    }
}

//class derivada
class Gato : Animal
{
    public override void ExibeNome()
    {
        Console.WriteLine($"Eu sou um gato meu nome é {Nome}");
    }
}

class Cachorro : Animal
{

}