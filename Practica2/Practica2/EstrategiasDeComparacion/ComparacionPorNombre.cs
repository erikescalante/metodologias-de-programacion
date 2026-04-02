using System;
using Practica2.Interfaces;

namespace Practica2.EstrategiasDeComparacion;

public class ComparacionPorNombre : IComparacion
{
    public bool SosIgual(Alumno a1, Alumno a2) => (a1.GetNombre == a2.GetNombre);
    public bool SosMenor(Alumno a1, Alumno a2) => 
        throw new NotImplementedException("No se puede determinar si un nombre es mayor que otro");
    public bool SosMayor(Alumno a1, Alumno a2) => 
        throw new NotImplementedException("No se puede determinar si un nombre es mayor que otro");
}