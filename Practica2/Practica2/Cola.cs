using System;
using System.Collections.Generic;
using Practica2.Interfaces;

namespace Practica2;

public class Cola : Coleccionable
{
    //variables
    private readonly LinkedList<Comparable> _elementos = [];

    //properties
    public bool IsEmpty => _elementos.Count == 0;
    
    //methods
    public Comparable? Peek() => (this.IsEmpty ? null : _elementos.First());
    
    public Comparable? Dequeue()
    {
        if (this.IsEmpty) return null;
        
        var top = _elementos.First();
        _elementos.RemoveFirst();
        return top;
    }

    //methods from Comparable interface.
    
    public int Cuantos() => _elementos.Count;

    public Comparable Minimo()
    {
        ArgumentOutOfRangeException.ThrowIfZero(_elementos.Count, "Cola vacía");

        var minimo = _elementos.First();
        foreach (var i in _elementos)
            if (minimo.SosMenor(i)) minimo = i;

        return minimo;
    }

    public Comparable Maximo()
    {
        ArgumentOutOfRangeException.ThrowIfZero(_elementos.Count, "Cola vacía");

        var mayor = _elementos.First();
        foreach (var i in _elementos)
            if (mayor.SosMayor(i)) mayor = i;

        return mayor;    }

    public void Agregar(Comparable elem) => _elementos.AddLast(elem);

    public bool Contiene(Comparable elem)
    {
        foreach(var i in _elementos)
            if (i.SosIgual(elem)) return true;
        
        return false;
    }
}