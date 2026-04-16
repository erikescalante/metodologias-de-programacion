using System;
using Practica2.Interfaces;
using Practica2.EstrategiasDeComparacion;

namespace Practica2;

public static class Program
{
    public static void Main(string[] args)
    {
        /*Módulo main ejercicio 2*/
        
        // var stack = new Pila(20);
        // var queue = new Cola();
        // var mult = new ColeccionMultiple(stack, queue);
        //
        // Operaciones.LlenaAlumnos(stack);
        // Operaciones.LlenaAlumnos(queue);
        // Console.WriteLine("\n--------------------------------------------------------------");
        // Console.WriteLine("Informe de coleccion multiple");
        // Console.WriteLine("--------------------------------------------------------------\n\n");
        // Operaciones.Informar(stack);
        
        
        /*Módulo main ejercicio 7*/
        
        // var stack = new Pila(20);
        // var queue = new Cola();
        // var set = new Conjunto();
        //
        // Operaciones.LlenaAlumnos(stack);
        // Operaciones.LlenaAlumnos(queue);
        // Operaciones.LlenaAlumnos(set);
        // Console.WriteLine("--------------------------------------------------------------");
        // Console.WriteLine("Elementos de la pila");
        // Console.WriteLine("--------------------------------------------------------------");
        // Impresora.ImprimirElementos(stack);
        // Console.WriteLine("\n--------------------------------------------------------------");
        // Console.WriteLine("Elementos de la cola");
        // Console.WriteLine("--------------------------------------------------------------");
        // Impresora.ImprimirElementos(queue);
        // Console.WriteLine("\n--------------------------------------------------------------");
        // Console.WriteLine("Elementos del conjunto");
        // Console.WriteLine("--------------------------------------------------------------");
        // Impresora.ImprimirElementos(set);
        
        
        /*Módulo main ejercicio 9*/

        var set = new Conjunto();
        Operaciones.LlenaAlumnos(set);
        
        Operaciones.CambiarEstrategia(set, new ComparacionPorNombre());
        Console.WriteLine("--------------------------------------------------------------");
        Console.WriteLine("Informe de los elementos del conjunto utilizando la estrategia de comparación por nombre");
        Console.WriteLine("--------------------------------------------------------------");
        Operaciones.Informar(set);
        Operaciones.CambiarEstrategia(set, new ComparacionPorLegajo());
        Console.WriteLine("\n--------------------------------------------------------------");
        Console.WriteLine("Informe de los elementos del conjunto utilizando la estrategia de comparación por legajo");
        Console.WriteLine("--------------------------------------------------------------");
        Operaciones.Informar(set);
        Operaciones.CambiarEstrategia(set, new ComparacionPorPromedio());
        Console.WriteLine("\n--------------------------------------------------------------");
        Console.WriteLine("Informe de los elementos del conjunto utilizando la estrategia de comparación por promedio");
        Console.WriteLine("--------------------------------------------------------------");
        Operaciones.Informar(set);
        Operaciones.CambiarEstrategia(set, new ComparacionPorDni());
        Console.WriteLine("\n--------------------------------------------------------------");
        Console.WriteLine("Informe de los elementos del conjunto utilizando la estrategia de comparación por dni");
        Console.WriteLine("--------------------------------------------------------------");
        Operaciones.Informar(set);
    }
}