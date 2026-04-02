using System;
using Practica1;

var stack = new Pila(20);
var queue = new Cola();
var mult = new ColeccionMultiple(stack, queue);
        
Operaciones.LlenaAlumnos(stack);
Operaciones.LlenaAlumnos(queue);
Console.WriteLine("\n--------------------------------------------------------------");
Console.WriteLine("Informe de coleccion multiple");
Console.WriteLine("--------------------------------------------------------------\n\n");
Operaciones.Informar(stack);


// var stack = new Pila(20);
// var queue = new Cola();
// var mult = new ColeccionMultiple(stack, queue);
//         
// Operaciones.Llenar(stack);
// Operaciones.Llenar(queue);
// Console.WriteLine("\n--------------------------------------------------------------");
// Console.WriteLine("Informe de pila");
// Console.WriteLine("--------------------------------------------------------------\n");
// Operaciones.Informar(stack);
// Console.ReadKey();
// Console.WriteLine("\n\n--------------------------------------------------------------");
// Console.WriteLine("Informe de cola");
// Console.WriteLine("--------------------------------------------------------------\n");
// Operaciones.Informar(queue);
// Console.ReadKey();
// Console.WriteLine("\n\n--------------------------------------------------------------");
// Console.WriteLine("Informe de colección múltiple");
// Console.WriteLine("--------------------------------------------------------------\n");
// Operaciones.Informar(mult);
// Console.ReadKey();