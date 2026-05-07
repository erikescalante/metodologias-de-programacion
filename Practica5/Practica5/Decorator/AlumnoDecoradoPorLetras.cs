using Practica5.Adapter;

namespace Practica5.Decorator;

public class AlumnoDecoradoPorLetras(IAlumno alumno) : AlumnoDecorado(alumno)
{
    public override string MostrarCalificacion()
    {
        var notaAlumno = base.MostrarCalificacion();
        string[] notasEnLetras = ["CERO", "UNO", "DOS", "TRES", "CUATRO", "CINCO", "SEIS", "SIETE", "OCHO", "NUEVE", "DIEZ"];

        return $"{notaAlumno} ({notasEnLetras[(int)Adicional.GetCalificacion()]})";
    }
}