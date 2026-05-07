using Practica5.Adapter;
using Practica5.FactoryMethod;
using Practica5.Strategy;

namespace Practica5.Proxy;

public class AlumnoProxy : IAlumno
{
    //variables
    private IAlumno? _alumno;

    private readonly Fabricables _nivelAlumno;
    private readonly string _nombre;
    private readonly string _apellido;
    private readonly int _dni;
    private readonly int _legajo;
    private readonly decimal _promedio;
    
    //constructors
    public AlumnoProxy(Fabricables lvlAlumno ,string nom, string ape, int dni, int leg, decimal prom)
    {
        _nivelAlumno = lvlAlumno;
        _nombre = nom;
        _apellido = ape;
        _dni = dni;
        _legajo = leg;
        _promedio = prom;
    }
    
    //methods (IAlumno interface)
    public string GetNombre() => $"{_nombre} creado con Proxy";

    public string GetApellido() => _apellido;

    public int GetDni() => _dni;

    public int GetLegajo() => _legajo;

    public decimal GetPromedio() => _promedio;
    
    public int ResponderPregunta(int pregunta)
    {
        if (_alumno is not null) return _alumno.ResponderPregunta(pregunta);

        _alumno = (IAlumno)FabricaDeComparables.CrearAleatorio(_nivelAlumno);
        ((Alumno)_alumno).SetNombre(_nombre);
        ((Alumno)_alumno).SetApellido(_apellido);
        ((Alumno)_alumno).SetDni(_dni);
        ((Alumno)_alumno).SetLegajo(_legajo);
        ((Alumno)_alumno).SetPromedio(_promedio);
        
        return _alumno.ResponderPregunta(pregunta);
    }

    public string MostrarCalificacion() => _alumno?.MostrarCalificacion() ?? "";

    public void SetCalificacion(decimal calificacion) => _alumno?.SetCalificacion(calificacion);

    public decimal GetCalificacion() => _alumno?.GetCalificacion() ?? -1;

    public IComparacion SetEstrategia(IComparacion estrategia) =>
        _alumno?.SetEstrategia(estrategia) ?? estrategia;

    public bool SosIgual(Comparable elem) => _alumno?.SosIgual(elem) ?? false;

    public bool SosMenor(Comparable elem) => _alumno?.SosMenor(elem) ?? false;

    public bool SosMayor(Comparable elem) => _alumno?.SosMayor(elem) ?? false;
}