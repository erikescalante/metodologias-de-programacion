using System;

namespace Practica3.Strategy;

public interface IComparacion
{
    bool SosIgual(Comparable a1, Comparable a2);
    bool SosMenor(Comparable a1, Comparable a2);
    bool SosMayor(Comparable a1, Comparable a2);
}