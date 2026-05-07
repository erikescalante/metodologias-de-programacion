namespace Practica5.Strategy;

public sealed class ComparacionPorCalificacion : IComparacion
{
    public bool SosIgual(Comparable a1, Comparable a2) =>
        (a1 is Alumno a && a2 is Alumno b) && (b.GetCalificacion() == a.GetCalificacion());
    public bool SosMenor(Comparable a1, Comparable a2) =>
        (a1 is Alumno a && a2 is Alumno b) && (b.GetCalificacion() < a.GetCalificacion());
    public bool SosMayor(Comparable a1, Comparable a2) =>
        (a1 is Alumno a && a2 is Alumno b) && (b.GetCalificacion() > a.GetCalificacion());
}