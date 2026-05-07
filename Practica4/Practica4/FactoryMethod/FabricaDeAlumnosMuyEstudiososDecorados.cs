using Practica4.Adapter;
using Practica4.Decorator;

namespace Practica4.FactoryMethod;

public class FabricaDeAlumnosMuyEstudiososDecorados : FabricaDeComparables
{
    protected override Comparable CrearAleatorio()
    {
        IAlumno alumno = (IAlumno)CrearAleatorio(Fabricables.AlumnoMuyEstudioso);
        IAlumno decorado = new AlumnoDecoradoPorLegajo(alumno);
        decorado = new AlumnoDecoradoPorLetras(decorado);
        decorado = new AlumnoDecoradoPorPromocion(decorado);
        decorado = new AlumnoDecoradoPorAsteriscos(decorado);
        return decorado;
    }

    protected override Comparable CrearPorTeclado()
    {
        IAlumno alumno = (IAlumno)CrearPorTeclado(Fabricables.AlumnoMuyEstudioso);
        IAlumno decorado = new AlumnoDecoradoPorLegajo(alumno);
        decorado = new AlumnoDecoradoPorLetras(decorado);
        decorado = new AlumnoDecoradoPorPromocion(decorado);
        decorado = new AlumnoDecoradoPorAsteriscos(decorado);
        return decorado;
    }
}