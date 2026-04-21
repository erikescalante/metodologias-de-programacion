using System;

namespace Practica3.Iterator;

public sealed class IteradorDePila(Pila pila) : Iterador
{
    //methods
    public void Primero(){}
    public Comparable? Actual() => pila.Top();
    public void Siguiente() => pila.Pop();
    public bool Fin() => pila.IsEmpty;
}