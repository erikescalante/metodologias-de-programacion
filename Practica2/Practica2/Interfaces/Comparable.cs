using System;

namespace Practica2.Interfaces;

// ReSharper disable once InconsistentNaming
public interface Comparable
{
    bool SosIgual(Comparable elem);
    bool SosMenor(Comparable elem);
    bool SosMayor(Comparable elem);
}