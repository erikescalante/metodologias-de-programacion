using System;

namespace Practica3.Strategy;

public sealed class ComparacionPorNombre : IComparacion
{
    public bool SosIgual(Comparable a1, Comparable a2) =>
        (a1 is Persona a && a2 is Persona b) && (b.GetNombre == a.GetNombre);
    public bool SosMenor(Comparable a1, Comparable a2) =>
        (a1 is Persona a && a2 is Persona b) && (b.GetNombre.Length < a.GetNombre.Length);
    public bool SosMayor(Comparable a1, Comparable a2) =>
        (a1 is Persona a && a2 is Persona b) && (b.GetNombre.Length > a.GetNombre.Length);
}