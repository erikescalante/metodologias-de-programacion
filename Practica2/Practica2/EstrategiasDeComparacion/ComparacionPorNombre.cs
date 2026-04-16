using System;
using Practica2.Interfaces;

namespace Practica2.EstrategiasDeComparacion;

public class ComparacionPorNombre : IComparacion
{
    public bool SosIgual(Alumno a1, Alumno a2) => (a2.GetNombre == a1.GetNombre);
    public bool SosMenor(Alumno a1, Alumno a2) => (a2.GetNombre.Length < a1.GetNombre.Length);
    public bool SosMayor(Alumno a1, Alumno a2) => (a2.GetNombre.Length > a1.GetNombre.Length);
}