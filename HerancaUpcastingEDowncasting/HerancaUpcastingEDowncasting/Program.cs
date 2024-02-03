using HerancaUpcastingEDowncasting;

Circulo circulo = new Circulo(10, 20); //upcasting - implicita
Forma forma = circulo;
forma.Desenhar();

Console.WriteLine(forma == circulo);

Circulo c = (Circulo)forma; //Downcasting - explicita
c.PintarCirculo();



Console.ReadKey();