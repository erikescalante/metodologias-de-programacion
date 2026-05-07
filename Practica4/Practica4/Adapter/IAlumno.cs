using Practica4.Strategy;

namespace Practica4.Adapter;

public interface IAlumno : Comparable
{
    IComparacion SetEstrategia(IComparacion estrategia);
    int GetLegajo();
    decimal GetPromedio();
    string GetNombre();
    string GetApellido();
    int GetDni();
    decimal GetCalificacion();
    void SetCalificacion(decimal calificacion);
    int ResponderPregunta(int pregunta);
    string MostrarCalificacion();
}