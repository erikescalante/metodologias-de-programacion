namespace Practica2.Interfaces;

// ReSharper disable once InconsistentNaming
public interface Iterador
{
    void Primero();
    Comparable Actual();
    void Siguiente();
    bool Fin();
}