using System;
using System.Collections.Generic;


namespace Practica1;

public class Pila : Coleccionable
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
    
    //properties
    public bool IsEmpty => (_elementos.Count == 0);
    
    //methods
    public Comparable? Top() => (this.IsEmpty ? _elementos[^1] : null);
    
    public Comparable? Pop()
    {
        if (_elementos.Count == 0) return null;
        
        var top = _elementos[^1];
        _elementos.RemoveAt(_elementos.Count - 1);
        return top;
    }

    //methods from Comparable interface.
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
}
