using System;
using Practica2.Interfaces;

namespace Practica2;

public class Conjunto(Comparable elemento) : Coleccionable
{
    //variable
    private readonly ArbolAvl _arbolito = new(elemento);
    
    //properties
    
    
    //methods
    public int Cuantos()
    {
        throw new NotImplementedException();
    }

    public Comparable Minimo() => _arbolito.Minimo;
    public Comparable Maximo() => _arbolito.Maximo;
    public void Agregar(Comparable elemento) => _arbolito.Agregar(elemento);
    public bool Contiene(Comparable elemento) => _arbolito.Incluido(elemento);
}