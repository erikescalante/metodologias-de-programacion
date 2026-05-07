namespace Practica5.Iterator;

public sealed class IteradorDeCola(Cola cola) : IIterador
{
    //methods
    public void Primero(){}
    public Comparable? Actual() => cola.Peek();
    public void Siguiente() => cola.Dequeue();
    public bool Fin() => cola.IsEmpty;
}