using System;
using Practica3.FactoryMethod;
using Practica3.Observer;

namespace Practica3;

public static class Program
{
    /*Función Main del ejercicio 6 y 9*/
    
    /*public static void Main(string[] args)
    {
        var stack = new Pila(20);
        var queue = new Cola();
        
        Operaciones.Llenar(stack, Fabricables.Profesor);
        Operaciones.Llenar(queue, Fabricables.Profesor);
        Console.WriteLine("\n--------------------------------------------------------------");
        Console.WriteLine("Informe de coleccion pila");
        Console.WriteLine("--------------------------------------------------------------\n\n");
        Operaciones.Informar(stack, Fabricables.Profesor);
    }*/
    
    /*Función Main del ejercicio 14 (entregable)*/
    
    public static void Main(string[] args)
    {
        var profesor = (Profesor)FabricaDeComparables.CrearAleatorio(Fabricables.Profesor);

        var p = new Pila();
        Operaciones.Llenar(p, Fabricables.Alumno);

        while (!p.IsEmpty)
        {
            if(p.Pop() is not Alumno a) continue;
            profesor.AgregarObservador(a);
        }
        
        Operaciones.DictadoDeClase(profesor);
        Console.ReadKey();
    }
}
