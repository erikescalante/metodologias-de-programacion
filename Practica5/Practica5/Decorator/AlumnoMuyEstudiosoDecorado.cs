using Practica5.Adapter;
using Practica5.Strategy;

namespace Practica5.Decorator;

public class AlumnoDecoradoMuyEstudiosoDecorado(AlumnoMuyEstudioso alumno) : IAlumno
{
    //variables
    private readonly AlumnoMuyEstudioso _adicional = alumno;
    
    //methods
    public IComparacion SetEstrategia(IComparacion estrategia) => _adicional.SetEstrategia(estrategia);
    public int GetLegajo() => _adicional.GetLegajo();
    public decimal GetPromedio() => _adicional.GetPromedio();
    public string GetNombre() => _adicional.GetNombre();
    public string GetApellido() => _adicional.GetApellido();
    public int GetDni() => _adicional.GetDni();
    public decimal GetCalificacion() => _adicional.GetCalificacion();
    public void SetCalificacion(decimal calificacion) => _adicional.SetCalificacion(calificacion);
    public int ResponderPregunta(int pregunta) => _adicional.ResponderPregunta(pregunta);
    public virtual string MostrarCalificacion() => _adicional.MostrarCalificacion();
    public bool SosIgual(Comparable elem) => elem is Alumno a && _adicional.SosIgual(a);
    public bool SosMenor(Comparable elem) => elem is Alumno a && _adicional.SosMenor(a);
    public bool SosMayor(Comparable elem) => elem is Alumno a && _adicional.SosMayor(a);
}