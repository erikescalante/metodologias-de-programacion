using Practica4.Strategy;
using Practica4.Observer;
using Practica4.Adapter;

namespace Practica4;

public class Alumno : Persona, IObservador, IAlumno
{
    //variables
    private IComparacion _estrategiaComparacion;
    private int _legajo;
    private decimal _promedio;
    private decimal _calificacion;

    //constructors
    public Alumno(string nombre, string apellido, int dni, int legajo, decimal promedio) : base(nombre, apellido, dni)
    {
        SetLegajo = legajo;
        SetPromedio = promedio;
        _estrategiaComparacion = new ComparacionPorLegajo();
    }
    public Alumno(string nombre, string apellido, int dni, int legajo, decimal promedio, decimal calificacion) : base(nombre, apellido, dni)
    {
        SetLegajo = legajo;
        SetPromedio = promedio;
        _estrategiaComparacion = new ComparacionPorLegajo();
        SetCalificacion(calificacion);
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

    public decimal SetPromedio
    {
        set
        {
            if (value is < 0 or > 10) throw new ArgumentOutOfRangeException($"Promedio inválido. El promedio ingresado no se encuentra en el rango permitido (0-10)");
            _promedio = value;
        }
    }

    //methods
    public int GetLegajo() => _legajo;
    public decimal GetPromedio() => _promedio;
    
    public decimal GetCalificacion() => _calificacion;
    public void SetCalificacion(decimal calificacion)
    {
        if (calificacion is < 0 or > 10)
            throw new ArgumentOutOfRangeException($"La calificacion ingresada no entra dentro de los valores permitidos (0-10)");
        
        _calificacion = calificacion;
    }
    
    //estrategia de comparación del alumno
    public IComparacion SetEstrategia(IComparacion estrategia) => _estrategiaComparacion = estrategia;
    public IComparacion GetEstrategia => _estrategiaComparacion;

    public override bool SosIgual(Comparable elem) => (elem is Alumno a && _estrategiaComparacion.SosIgual(this, a));
    public override bool SosMayor(Comparable elem) => (elem is Alumno a && _estrategiaComparacion.SosMayor(this, a));
    public override bool SosMenor(Comparable elem) => (elem is Alumno a && _estrategiaComparacion.SosMenor(this, a));

    //métodos del patrón de diseño observer (práctica 03)
    private void PrestarAtencion() => Console.WriteLine("Estoy prestando atención a la clase");

    private void Distraerse()
    {
        var rand = new Random();
        var distracciones = new[]
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
    
    //métodos del ejercicio 1, práctica 4 (patrón adapter)
    public virtual int ResponderPregunta(int pregunta) => new Random().Next(0, 3);
    public virtual string MostrarCalificacion() => $"{Nombre} {Apellido}\t{_calificacion}";
    
    //ToString method
    public override string ToString() => $"{Nombre} ({Dni}) - Legajo: {_legajo} - Promedio: {_promedio}";
    
    public void Actualizar(IObservado observado)
    {
        var habla = ((Profesor)observado).Hablando;
        
        if(habla) this.PrestarAtencion();
        else this.Distraerse();
    }
}