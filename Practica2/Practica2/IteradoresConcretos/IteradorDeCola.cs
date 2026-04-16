using System;
using Practica2.Interfaces;

namespace Practica2.IteradoresConcretos;

public class IteradorDeCola : Iterador
{
    //variables
    private Cola _q;
    
    //constructor
    public IteradorDeCola(Cola cola)
    {
        _q = cola;
    }
    
    //methods
    public void Primero(){}
    public Comparable Actual() => _q.Peek();
    public void Siguiente() => _q.Dequeue();
    public bool Fin() => _q.IsEmpty;
}