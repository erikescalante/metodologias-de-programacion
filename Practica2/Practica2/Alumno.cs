using System;
using Practica2.EstrategiasDeComparacion;
using Practica2.Interfaces;

namespace Practica2;

public sealed class Alumno : Persona
{
    //variables
    private IComparacion _estrategiaComparacion;
    private int _legajo;
    private decimal _promedio;

    //constructor
    public Alumno(string nombre, int dni, int legajo, decimal promedio) : base(nombre, dni)
    {
        SetLegajo = legajo;
        SetPromedio = promedio;
        _estrategiaComparacion = new ComparacionPorLegajo();
    }

    //properties
    private int SetLegajo
    {
        set
        {
            ArgumentOutOfRangeException.ThrowIfNegative(value, "Legajo invalido.");
            _legajo = value;
        }
    }
    public int GetLegajo => _legajo;

    private decimal SetPromedio
    {
        set
        {
            if (value is < 0 or > 10) throw new ArgumentOutOfRangeException($"Promedio inválido. El promedio ingresado no se encuentra en el rango permitido (0-10)");
            _promedio = value;
        }
    }
    public decimal GetPromedio => _promedio;
    
    //methods
    
    //estrategia de comparación del alumno
    public IComparacion SetEstrategia(IComparacion estrategia) => _estrategiaComparacion = estrategia;
    public IComparacion GetEstrategia => _estrategiaComparacion;
    
    //métodos sobreescritos (override methods)

    //métodos de la interfaz Comparables sobreescritos basados en el PROMEDIO de los alumnos.
    public override bool SosIgual(Comparable elem) => (elem is Alumno a && _estrategiaComparacion.SosIgual(this, a));
    public override bool SosMayor(Comparable elem) => (elem is Alumno a && _estrategiaComparacion.SosMayor(this, a));
    public override bool SosMenor(Comparable elem) => (elem is Alumno a && _estrategiaComparacion.SosMenor(this, a));

    //ToString method
    public override string ToString() => $"{Nombre} ({Dni}) - Legajo: {_legajo} - Promedio: {_promedio}";
}