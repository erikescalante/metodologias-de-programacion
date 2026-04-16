using System;
using Practica2.EstrategiasDeComparacion;
using Practica2.Interfaces;

namespace Practica2;

public static class Operaciones
{
    //variable
    private static readonly Random Rand = new Random();

    //methods
    
    //método llenar del ejercicio número 5 (práctica 1)
    public static void Llenar(Coleccionable coleccion)
    {
        for (var i = 0; i < 20; i++)
        {
            Comparable c = new Numero(Rand.Next());
            coleccion.Agregar(c);
        }
    }
    
    //método informar del ejercicio número 6 (práctica 1)
    public static void Informar(Coleccionable coleccion)
    {
        if (coleccion.Cuantos() == 0)
            Console.WriteLine("La colección está vacía.");
        else
        {
            //Console.WriteLine($"=> cantidad de elementos: {coleccion.Cuantos()} comparables");
            var min = coleccion.Minimo();
            Console.WriteLine($"=> elemento mínimo: " + min.ToString());
            var max = coleccion.Maximo();
            Console.WriteLine($"=> elemento máximo: " + max.ToString());

            /*Este trozo de código ha sido comentado, para realizar el ejercicio 2 de la segunda práctica*/
            
            // Console.WriteLine("\n*********************************************************************\n");
            // Console.WriteLine("Ingrese el comparable que desea saber si se encuentra en la colección");
            // Console.Write("=> ");
            // var esComparable = int.TryParse(Console.ReadLine(), out var entry);
            //
            // while (!esComparable)
            // {
            //     Console.WriteLine("\n\tEl valor ingresado es inválido. Por favor intente ingresar un valor entero.");
            //     Console.Write("\t=> ");
            //     esComparable = int.TryParse(Console.ReadLine(), out entry);
            // }
            //
            // Console.Write(coleccion.Contiene(new Numero(entry))
            //     ? "\nEl elemento ingresado sí está en la colección"
            //     : "\nEl elemento ingresado no está en la colección");
            
            
            /*Este trozo de código ha sido comentado para realizar ejercicio 9 de la segunda práctica sin que se pida la comparación*/
            
            // Console.WriteLine("\n*********************************************************************\n");
            // Console.WriteLine("Ingrese el promedio del alumno que desea saber si se encuentra en la colección");
            // Console.Write("=> ");
            // var esPromedio = int.TryParse(Console.ReadLine(), out var entry);
            //
            // while (!esPromedio || entry is < 0 or > 10)
            // {
            //     Console.WriteLine("\n\tEl valor ingresado es inválido. Por favor intente ingresar un valor que corresponda con un promedio (0 a 10).");
            //     Console.Write("\t=> ");
            //     esPromedio = int.TryParse(Console.ReadLine(), out entry);
            // }
            //
            // Console.Write(coleccion.Contiene(new Alumno("john doyle", 12345678, 1234, entry))
            //     ? "\nSí existe un alumno con el promedio ingresado."
            //     : "\nNo existe ningún alumno con el promedio ingresado.");
        }
    }
    
    //método LlenaAlumnos del ejercicio 2 (práctica 2) y su dependencia NombreAleatorio.
    public static void LlenaAlumnos(Coleccionable coleccion)
    {
        for (var i = 0; i < 20; i++)
        {
            Comparable c = new Alumno(NombreAleatorio(8), 
                new Random().Next(1000000, 99999999),
                new Random().Next(0, 99999999), 
                (decimal)new Random().Next(0, 10));

            ((Alumno)c).SetEstrategia(new ComparacionPorPromedio());
            coleccion.Agregar(c);
        }
    }

    private static string NombreAleatorio(int longitud)
    {
        const string caracteres = "abcdefghijklmnñopqrstuvwxyz";
        var resultado = new char[longitud];

        for (var i = 0; i < longitud; i++)
            resultado[i] = caracteres[Rand.Next(caracteres.Length-1)];

        return new string(resultado);
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
}