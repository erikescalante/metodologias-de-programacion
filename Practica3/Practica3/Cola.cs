using System;
using System.Collections.Generic;
using Practica3.Iterator;

namespace Practica3;

public sealed class Cola : Coleccionable, Iterable
{
    //variables
    private readonly LinkedList<Comparable?> _elementos = [];

    //properties
    public bool IsEmpty => _elementos.Count == 0;
    
    //methods
    public Comparable? Peek() => (this.IsEmpty)
        ? throw new NullReferenceException("Cola vacía")
        : _elementos.First();
    
    public Comparable? Dequeue()
    {
        if (this.IsEmpty) throw new NullReferenceException("Cola vacía");
        
        var top = _elementos.First();
        _elementos.RemoveFirst();
        return top;
    }

    //methods from Comparable interface.
    
    public int Cuantos() => _elementos.Count;

    public Comparable? Minimo()
    {
        ArgumentOutOfRangeException.ThrowIfZero(_elementos.Count, "Cola vacía");

        var minimo = _elementos.First();
        foreach (var i in _elementos)
        {
            if (i is null) continue;
            if (minimo is null || minimo.SosMenor(i)) minimo = i;
        }

        return minimo;
    }

    public Comparable? Maximo()
    {
        ArgumentOutOfRangeException.ThrowIfZero(_elementos.Count, "Cola vacía");

        var maximo = _elementos.First();
        foreach (var i in _elementos)
        {
            if (i is null) continue;
            if (maximo is null || maximo.SosMayor(i)) maximo = i;
        }

        return maximo;
    }

    public void Agregar(Comparable elem) => _elementos.AddLast(elem);

    public bool Contiene(Comparable elem)
    {
        foreach (var i in _elementos)
        {
            if (i is null) continue;
            if (i.SosIgual(elem)) return true;
        }
        
        return false;
    }
    
    //method by Iterable interface
    
    public Iterador CrearIterador() => new IteradorDeCola(this);
}