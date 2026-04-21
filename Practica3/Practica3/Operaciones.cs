using System;
using Practica3.Strategy;
using Practica3.FactoryMethod;
using Practica3.Observer;

namespace Practica3;

public static class Operaciones
{
    //variable
    private static readonly Random Rand = new Random();

    //methods
    
    //método DictadoDeClase del ejercicio 13 de la práctica 3
    public static void DictadoDeClase(Profesor profesor)
    {
        for (var i = 0; i < 5; i++)
        {
            profesor.HablarHaciaLaClase();
            profesor.EscribirEnPizarron();
        }
    }
    
    //método Llenar del ejercicio 6 de la práctica 3
    public static void Llenar(Coleccionable c, Fabricables  f)
    {
        for (var i = 0; i < 20; i++)
        {
            var comparable = FabricaDeComparables.CrearAleatorio(f);
            c.Agregar(comparable);
        }
    }
    
    //método Informar del ejercicio 6 de la práctica 3
    public static void Informar(Coleccionable coleccion, Fabricables f)
   {
       if (coleccion.Cuantos() == 0)
           Console.WriteLine("La colección está vacía.");
       else
       {
           Console.WriteLine($"=> cantidad de elementos: {coleccion.Cuantos()} comparables");
           var min = coleccion.Minimo();
           Console.WriteLine($"=> elemento mínimo: " + min);
           var max = coleccion.Maximo();
           Console.WriteLine($"=> elemento máximo: " + max);
           Console.WriteLine("\n-----------------------------------------------------------------");
           Console.WriteLine(
               "A continuación, ingrese los datos del comparable que desee saber    \nsi se encuentra en la colección...\n");
           
           var comparable = FabricaDeComparables.CrearPorTeclado(f);
           Console.WriteLine(coleccion.Contiene(comparable)
               ? "El comparable sí se encuentra en la colección"
               : "El comparable no se encuentra en la colección");
       }
   }
    
    //método CambiarEstrategia del ejercicio 8 de la práctica 2
    public static void CambiarEstrategia(Coleccionable coleccion, IComparacion estrategia)
    {
        var iterador = coleccion.CrearIterador();
        iterador.Primero();
        
        while (!iterador.Fin())
        {
            if (iterador.Actual() is Alumno a) a.SetEstrategia(estrategia);
            iterador.Siguiente();
        }
    }
    
    //método ImprimirElementos del ejercicio 6 de la práctica 2
    public static void ImprimirElementos(Coleccionable coleccion)
    {
        var iterador = coleccion.CrearIterador();
        iterador.Primero();
        
        while (!iterador.Fin())
        {
            var actual = iterador.Actual()?.ToString() ?? "null";
            Console.WriteLine(actual);
            iterador.Siguiente();
        }
    }
}
