using System;

namespace Practica3.Strategy;

public sealed class ComparacionPorDni : IComparacion
{
    public bool SosIgual(Comparable a1, Comparable a2) =>
        (a1 is Persona a && a2 is Persona b) && (b.GetDni == a.GetDni);
    public bool SosMenor(Comparable a1, Comparable a2) =>
        (a1 is Persona a && a2 is Persona b) && (b.GetDni < a.GetDni);
    public bool SosMayor(Comparable a1, Comparable a2) =>
        (a1 is Persona a && a2 is Persona b) && (b.GetDni > a.GetDni);
}