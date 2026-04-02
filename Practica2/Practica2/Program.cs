using System;
using Practica2;

var stack = new Pila(20);
var queue = new Cola();
var mult = new ColeccionMultiple(stack, queue);
        
Operaciones.LlenaAlumnos(stack);
Operaciones.LlenaAlumnos(queue);
Console.WriteLine("\n--------------------------------------------------------------");
Console.WriteLine("Informe de coleccion multiple");
Console.WriteLine("--------------------------------------------------------------\n\n");
Operaciones.Informar(mult);