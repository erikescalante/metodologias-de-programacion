using Practica5.Observer;

namespace Practica5.Strategy;

public class ComparacionPorAntiguedad : IComparacion
{
    public bool SosIgual(Comparable a1, Comparable a2) =>
        (a1 is Profesor a && a2 is Profesor b) && (b.Antiguedad == a.Antiguedad);
    public bool SosMenor(Comparable a1, Comparable a2) =>
        (a1 is Profesor a && a2 is Profesor b) && (b.Antiguedad < a.Antiguedad);
    public bool SosMayor(Comparable a1, Comparable a2) =>
        (a1 is Profesor a && a2 is Profesor b) && (b.Antiguedad > a.Antiguedad);
}