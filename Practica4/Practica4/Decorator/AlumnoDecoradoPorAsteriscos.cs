using Practica4.Adapter;

namespace Practica4.Decorator;

public class AlumnoDecoradoPorAsteriscos(IAlumno alumno) : AlumnoDecorado(alumno)
{
    public override string MostrarCalificacion()
    {
        var resultado = "";
        var notaAlumno = base.MostrarCalificacion();
        
        for (var i = 0; i < notaAlumno.Length + 6; i++) { resultado += "*"; }
        resultado += $"\n* {notaAlumno} *\n";
        for (var i = 0; i < notaAlumno.Length + 6; i++) { resultado += "*"; }

        return resultado;
    }
}