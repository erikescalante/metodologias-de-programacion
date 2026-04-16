using System;
using Practica2.Interfaces;

namespace Practica2;

public static class Impresora
{
    //método ImprimirElementos del ejercicio 6 de la práctica 2
    public static void ImprimirElementos(Coleccionable coleccion)
    {
        var iterador = coleccion.CrearIterador();
        iterador.Primero();
        
        while (!iterador.Fin())
        {
            Console.WriteLine(iterador.Actual().ToString());
            iterador.Siguiente();
        }
    }
}