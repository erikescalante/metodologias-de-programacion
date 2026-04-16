using System;
using Practica2.Interfaces;
using Practica2.IteradoresConcretos;

namespace Practica2;

public class Conjunto : Coleccionable, Iterable
{
    //variable
    private readonly List<Comparable> _elementos = [];
    //methods
    public IReadOnlyList<Comparable> Elementos() => _elementos;
    
    //methods from Comparable interface
    public int Cuantos() => _elementos.Count;

    public Comparable Minimo()
    {
        ArgumentOutOfRangeException.ThrowIfZero(_elementos.Count, "Conjunto vacío");
        var minimo = _elementos[0];
        
        foreach (var elem in _elementos)
        {
            if (minimo.SosMenor(elem)) minimo = elem;
        }

        return minimo;
    }
    public Comparable Maximo()
    { 
        ArgumentOutOfRangeException.ThrowIfZero(_elementos.Count, "Conjunto vacío");
        
        var maximo = _elementos[0];
        foreach (var elem in _elementos)
        {
            if (maximo.SosMayor(elem)) maximo = elem;
        }

        return maximo;
    }
    public bool Contiene(Comparable elemento) => _elementos.Contains(elemento);
    
    //métodos propios
    public void Agregar(Comparable elemento)
    {
        if(!_elementos.Contains(elemento)) _elementos.Add(elemento);
    }

    public bool Pertenece(Comparable elemento) => Contiene(elemento);
    
    //methods by Iterable interface

    public Iterador CrearIterador() => new IteradorDeConjunto(this);
}