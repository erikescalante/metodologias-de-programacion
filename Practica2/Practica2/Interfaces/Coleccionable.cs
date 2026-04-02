using System;

namespace Practica2.Interfaces;

// ReSharper disable once InconsistentNaming
public interface Coleccionable
{
    int Cuantos(); //Devuelve la cantidad de elementos comparables que tiene el coleccionable
    
    Comparable Minimo(); //Devuelve el elemento de menor valor de la colección
    
    Comparable Maximo(); //Devuelve el elemento de mayor valor de la colección
    
    void Agregar(Comparable elem);  //Agrega el comparable recibido por
                                        //parámetro a la colección que recibe el mensaje
    bool Contiene(Comparable elem); //Devuelve verdadero si el comparable recibido por parámetro está
                                        //incluido en la colección y falso en caso contrario
}