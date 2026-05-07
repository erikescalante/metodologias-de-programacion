using Practica5.Adapter;

namespace Practica5.Decorator;

public class AlumnoDecoradoPorLegajo(IAlumno alumno) : AlumnoDecorado(alumno)
{
    public override string MostrarCalificacion()
    {
        var notaAlumno = base.MostrarCalificacion();
        var indiceTabulacion = notaAlumno.IndexOf('\t');

        return notaAlumno.Insert(indiceTabulacion, ($" ({Adicional.GetLegajo()})"));
    }
}