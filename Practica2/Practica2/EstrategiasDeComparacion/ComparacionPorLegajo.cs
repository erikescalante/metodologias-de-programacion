using System;
using Practica2.Interfaces;

namespace Practica2.EstrategiasDeComparacion;

public class ComparacionPorLegajo : IComparacion
{
    public bool SosIgual(Alumno a1, Alumno a2) => (a1.GetLegajo == a2.GetLegajo);
    public bool SosMenor(Alumno a1, Alumno a2) => (a1.GetLegajo == a2.GetLegajo);
    public bool SosMayor(Alumno a1, Alumno a2) => (a1.GetLegajo == a2.GetLegajo);
}