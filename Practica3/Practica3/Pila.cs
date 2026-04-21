using System;
using System.Collections.Generic;
using Practica3.Iterator;

namespace Practica3;

public sealed class Pila : Coleccionable
{
    //variables
    private readonly List<Comparable?> _elementos;
    
    //constructor
    public Pila() => _elementos = [];

    public Pila(int capacidad)
    {
        ArgumentOutOfRangeException.ThrowIfNegative(capacidad, "Entrada inválida. No existe la capacidad negativa");
        _elementos = new List<Comparable?>(capacidad);
    }
    
    //methods
    public bool IsEmpty => (_elementos.Count == 0);
    
    public Comparable? Top() => (this.IsEmpty) 
        ? throw new NullReferenceException("Pila vacía")
        :_elementos[^1] ;
    
    public Comparable? Pop()
    {
        if (_elementos.Count == 0) throw new NullReferenceException("Pila vacía");
        
        var top = _elementos[^1];
        _elementos.RemoveAt(_elementos.Count - 1);
        return top;
    }

    //methods by Comparable interface.
    public int Cuantos() => _elementos.Count;

    public Comparable? Minimo()
    {
        ArgumentOutOfRangeException.ThrowIfZero(_elementos.Count, "Pila vacía");

        var minimo = _elementos[0];
        foreach (var i in _elementos)
        {
            if (i is null) continue;
            if (minimo is null || minimo.SosMenor(i)) minimo = i;
        }

        return minimo;
    }

    public Comparable? Maximo()
    {
        ArgumentOutOfRangeException.ThrowIfZero(_elementos.Count, "Pila vacía");

        var maximo = _elementos[0];
        foreach (var i in _elementos)
        {
            if (i is null) continue;
            if (maximo is null || maximo.SosMayor(i)) maximo = i;
        }

        return maximo;    
    }

    public void Agregar(Comparable elem) => _elementos.Add(elem);

    public bool Contiene(Comparable elem)
    {
        foreach (var i in _elementos)
        {
            if (i is null) continue;
            if (i.SosIgual(elem)) return true;
        }
        
        return false;
    }
    
    //methods by Iterable interface
    
    public Iterador CrearIterador() => new IteradorDePila(this);
}
