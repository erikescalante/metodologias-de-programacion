using System;

namespace Practica3;

// ReSharper disable once InconsistentNaming
public interface Comparable
{
    bool SosIgual(Comparable elem);
    bool SosMenor(Comparable elem);
    bool SosMayor(Comparable elem);
}