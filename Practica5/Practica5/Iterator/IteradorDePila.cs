namespace Practica5.Iterator;

public sealed class IteradorDePila(Pila pila) : IIterador
{
    //methods
    public void Primero(){}
    public Comparable? Actual() => pila.Top();
    public void Siguiente() => pila.Pop();
    public bool Fin() => pila.IsEmpty;
}