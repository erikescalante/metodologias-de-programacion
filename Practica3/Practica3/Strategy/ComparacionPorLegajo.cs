using System;

namespace Practica3.Strategy;

public sealed class ComparacionPorLegajo : IComparacion
{
    public bool SosIgual(Comparable a1, Comparable a2) =>
        (a1 is Alumno a && a2 is Alumno b) && (b.GetLegajo == a.GetLegajo);
    public bool SosMenor(Comparable a1, Comparable a2) =>
        (a1 is Alumno a && a2 is Alumno b) && (b.GetLegajo < a.GetLegajo);
    public bool SosMayor(Comparable a1, Comparable a2) =>
        (a1 is Alumno a && a2 is Alumno b) && (b.GetLegajo > a.GetLegajo);
}