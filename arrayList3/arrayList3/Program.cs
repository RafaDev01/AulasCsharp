﻿using System.Collections;

Console.WriteLine("ArrayList part 3");

var lista = new ArrayList() { "Maria", 5, true };

int[] array1 = { 1, 2, 3};

lista.AddRange(array1);

lista.InsertRange(2, array1);

Console.ReadKey();