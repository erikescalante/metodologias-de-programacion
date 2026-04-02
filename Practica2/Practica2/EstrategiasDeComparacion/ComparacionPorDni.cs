using System;
using Practica2.Interfaces;

namespace Practica2.EstrategiasDeComparacion;

public class ComparacionPorDni : IComparacion
{
    public bool SosIgual(Alumno a1, Alumno a2) => (a1.GetDni == a2.GetDni);
    public bool SosMenor(Alumno a1, Alumno a2) => (a1.GetDni == a2.GetDni);
    public bool SosMayor(Alumno a1, Alumno a2) => (a1.GetDni == a2.GetDni);
}