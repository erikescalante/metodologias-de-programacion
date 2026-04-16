using System;
using System.Collections.Generic;
using Practica2.Interfaces;
using Practica2.IteradoresConcretos;

namespace Practica2;

public class Pila : Coleccionable, Iterable
{
    //variables
    private readonly List<Comparable> _elementos;
    
    //constructor
    public Pila() => _elementos = [];

    public Pila(int capacidad)
    {
        ArgumentOutOfRangeException.ThrowIfNegative(capacidad, "Entrada inválida. No existe la capacidad negativa");
        _elementos = new List<Comparable>(capacidad);
    }
    
    //methods
    public bool IsEmpty => (_elementos.Count == 0);
    
    public Comparable Top() => (this.IsEmpty) 
        ? throw new NullReferenceException("Pila vacía")
        :_elementos[^1] ;
    
    public Comparable Pop()
    {
        if (_elementos.Count == 0) throw new NullReferenceException("Pila vacía");
        
        var top = _elementos[^1];
        _elementos.RemoveAt(_elementos.Count - 1);
        return top;
    }

    //methods by Comparable interface.
    public int Cuantos() => _elementos.Count;

    public Comparable Minimo()
    {
        ArgumentOutOfRangeException.ThrowIfZero(_elementos.Count, "Pila vacía");

        var minimo = _elementos[0];
        foreach (var i in _elementos)
            if (minimo.SosMenor(i)) minimo = i;

        return minimo;
    }

    public Comparable Maximo()
    {
        ArgumentOutOfRangeException.ThrowIfZero(_elementos.Count, "Pila vacía");

        var mayor = _elementos[0];
        foreach (var i in _elementos)
            if (mayor.SosMayor(i)) mayor = i;

        return mayor;    
    }

    public void Agregar(Comparable elem) => _elementos.Add(elem);

    public bool Contiene(Comparable elem)
    {
        foreach(var i in _elementos)
            if (i.SosIgual(elem)) return true;
        
        return false;
    }
    
    //methods by Iterable interface
    
    public Iterador CrearIterador() => new IteradorDePila(this);
}
