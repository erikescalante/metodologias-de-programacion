using System;
using Practica3;

namespace Practica3.Iterator;

// ReSharper disable once InconsistentNaming
public interface Iterador
{
    void Primero();
    Comparable? Actual();
    void Siguiente();
    bool Fin();
}