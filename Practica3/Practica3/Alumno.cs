using System;
using Practica3.Strategy;
using Practica3.Observer;

namespace Practica3;

public sealed class Alumno : Persona, IObservador
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
    
    public override bool SosIgual(Comparable elem) => (elem is Alumno a && _estrategiaComparacion.SosIgual(this, a));
    public override bool SosMayor(Comparable elem) => (elem is Alumno a && _estrategiaComparacion.SosMayor(this, a));
    public override bool SosMenor(Comparable elem) => (elem is Alumno a && _estrategiaComparacion.SosMenor(this, a));

    //métodos del patrón de diseño observer (práctica 03)
    public void PrestarAtencion() => Console.WriteLine("Estoy prestando atención a la clase");

    public void Distraerse()
    {
        var rand = new Random();
        var distracciones = new string[]
        {
            "Mirando por la ventana",
            "Dibujando el banco",
            "Tirando avión de papel",
            "Mirando el celular",
            "Hablando con un compañero",
            "Disociando",
            "Escribiendo un poema"
        };
        var distraccionActual = distracciones[rand.Next(distracciones.Length)];
        Console.WriteLine(distraccionActual);
    }
    
    //ToString method
    public override string ToString() => $"{Nombre} ({Dni}) - Legajo: {_legajo} - Promedio: {_promedio}";
    
    public void Actualizar(IObservado observado)
    {
        var habla = ((Profesor)observado)?.Hablando ?? false;
        
        if(habla) this.PrestarAtencion();
        else this.Distraerse();
    }
}