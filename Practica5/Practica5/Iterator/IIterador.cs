namespace Practica5.Iterator;

public interface IIterador
{
    void Primero();
    Comparable? Actual();
    void Siguiente();
    bool Fin();
}