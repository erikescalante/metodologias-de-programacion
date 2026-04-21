using System;

namespace Practica3.Iterator;

public sealed class IteradorDeCola(Cola cola) : Iterador
{
    //methods
    public void Primero(){}
    public Comparable? Actual() => cola.Peek();
    public void Siguiente() => cola.Dequeue();
    public bool Fin() => cola.IsEmpty;
}