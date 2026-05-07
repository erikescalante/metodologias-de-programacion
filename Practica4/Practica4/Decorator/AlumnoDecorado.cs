using Practica4.Adapter;
using Practica4.Strategy;

namespace Practica4.Decorator;

public class AlumnoDecorado(IAlumno alumno) : IAlumno
{
    //variables
    protected readonly IAlumno Adicional = alumno;
    
    //methods
    public IComparacion SetEstrategia(IComparacion estrategia) => Adicional.SetEstrategia(estrategia);
    public int GetLegajo() => Adicional.GetLegajo();
    public decimal GetPromedio() => Adicional.GetPromedio();
    public string GetNombre() => Adicional.GetNombre();
    public string GetApellido() => Adicional.GetApellido();
    public int GetDni() => Adicional.GetDni();
    public decimal GetCalificacion() => Adicional.GetCalificacion();
    public void SetCalificacion(decimal calificacion) => Adicional.SetCalificacion(calificacion);
    public int ResponderPregunta(int pregunta) => Adicional.ResponderPregunta(pregunta);
    public virtual string MostrarCalificacion() => Adicional.MostrarCalificacion();
    public bool SosIgual(Comparable elem) => elem is Alumno a && Adicional.SosIgual(a);
    public bool SosMenor(Comparable elem) => elem is Alumno a && Adicional.SosMenor(a);
    public bool SosMayor(Comparable elem) => elem is Alumno a && Adicional.SosMayor(a);
}