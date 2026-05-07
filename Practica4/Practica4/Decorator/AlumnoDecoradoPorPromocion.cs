using Practica4.Adapter;

namespace Practica4.Decorator;

public class AlumnoDecoradoPorPromocion(IAlumno alumno) : AlumnoDecorado(alumno)
{
    public override string MostrarCalificacion()
    {
        var notaAlumno = base.MostrarCalificacion();
        var calificacion = Adicional.GetCalificacion();

        return notaAlumno + (calificacion) switch
        {
            < 4 => $" (DESAPROBADO)",
            > 4 and < 7 => $" (APROBADO)",
            _ => " (PROMOCION)"
        };
    }
}