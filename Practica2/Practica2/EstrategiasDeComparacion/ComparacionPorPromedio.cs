using System;
using Practica2.Interfaces;

namespace Practica2.EstrategiasDeComparacion;

public class ComparacionPorPromedio : IComparacion
{
    public bool SosIgual(Alumno a1, Alumno a2) => (a1.GetPromedio == a2.GetPromedio);
    public bool SosMenor(Alumno a1, Alumno a2) => (a2.GetPromedio < a1.GetPromedio);
    public bool SosMayor(Alumno a1, Alumno a2) => (a2.GetPromedio > a1.GetPromedio);
}