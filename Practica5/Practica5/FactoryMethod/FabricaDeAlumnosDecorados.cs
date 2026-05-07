using Practica5.Adapter;
using Practica5.Decorator;

namespace Practica5.FactoryMethod;

public class FabricaDeAlumnosDecorados : FabricaDeComparables
{
    protected override Comparable CrearAleatorio()
    {
        IAlumno alumno = (IAlumno)CrearAleatorio(Fabricables.Alumno);
        IAlumno decorado = new AlumnoDecoradoPorLegajo(alumno);
        decorado = new AlumnoDecoradoPorLetras(decorado);
        decorado = new AlumnoDecoradoPorPromocion(decorado);
        decorado = new AlumnoDecoradoPorAsteriscos(decorado);
        return decorado;
    }

    protected override Comparable CrearPorTeclado()
    {
        IAlumno alumno = (IAlumno)CrearPorTeclado(Fabricables.Alumno);
        IAlumno decorado = new AlumnoDecoradoPorLegajo(alumno);
        decorado = new AlumnoDecoradoPorLetras(decorado);
        decorado = new AlumnoDecoradoPorPromocion(decorado);
        decorado = new AlumnoDecoradoPorAsteriscos(decorado);
        return decorado;
    }
}