using System;

namespace Practica3.Strategy;

public sealed class ComparacionPorPromedio : IComparacion
{
    public bool SosIgual(Comparable a1, Comparable a2) =>
        (a1 is Alumno a && a2 is Alumno b) && (b.GetPromedio == a.GetPromedio);
    public bool SosMenor(Comparable a1, Comparable a2) =>
        (a1 is Alumno a && a2 is Alumno b) && (b.GetPromedio == a.GetPromedio);
    public bool SosMayor(Comparable a1, Comparable a2) =>
        (a1 is Alumno a && a2 is Alumno b) && (b.GetPromedio == a.GetPromedio);
}