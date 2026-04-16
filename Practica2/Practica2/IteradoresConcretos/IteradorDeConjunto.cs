using System;
using Practica2.Interfaces;

namespace Practica2.IteradoresConcretos;

public class IteradorDeConjunto : Iterador
{
    //variable
    private IReadOnlyList<Comparable> _elementos;
    private int _actual;

    //constructor
    public IteradorDeConjunto(Conjunto c)
    {
        _elementos = c.Elementos();
        _actual = 0;
    }
    
    //methods
    
    public void Primero() => _actual = 0;
    public Comparable Actual() => _elementos[_actual];
    public void Siguiente() => _actual++;
    public bool Fin() => _actual >= _elementos.Count - 1;
}