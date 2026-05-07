namespace Practica5.FactoryMethod;

public abstract class FabricaDeComparables
{
    public static Comparable CrearAleatorio(Fabricables fabricable)
    {
        FabricaDeComparables fabrica = new FabricaDeNumeros();

        switch (fabricable)
        {
            case Fabricables.Numero: { break; }
            case Fabricables.Profesor: { fabrica = new FabricaDeProfesores(); break; }
            case Fabricables.Alumno: { fabrica = new FabricaDeAlumnos(); break; }
            case Fabricables.AlumnoMuyEstudioso: { fabrica = new FabricaDeAlumnosMuyEstudiosos(); break; }
            case Fabricables.AlumnoDecorado: { fabrica = new FabricaDeAlumnosDecorados(); break; }
            case Fabricables.AlumnoMuyEstudiosoDecorado: { fabrica = new FabricaDeAlumnosMuyEstudiososDecorados(); break; }
            case Fabricables.AlumnoProxy: { fabrica = new FabricaDeAlumnosProxies(); break; }
            case Fabricables.AlumnoMuyEstudiosoProxy: { fabrica = new FabricaDeAlumnosMuyEstudiososProxies(); break; }
        }

        return fabrica.CrearAleatorio();
    }

    public static Comparable CrearPorTeclado(Fabricables fabricable)
    {
        FabricaDeComparables fabrica = new FabricaDeNumeros();

        switch (fabricable)
        {
            case Fabricables.Numero: { break; }
            case Fabricables.Profesor: { fabrica = new FabricaDeProfesores(); break; }
            case Fabricables.Alumno: { fabrica = new FabricaDeAlumnos(); break; }
            case Fabricables.AlumnoMuyEstudioso: { fabrica = new FabricaDeAlumnosMuyEstudiosos(); break; }
            case Fabricables.AlumnoDecorado: { fabrica = new FabricaDeAlumnosDecorados(); break; }
            case Fabricables.AlumnoMuyEstudiosoDecorado: { fabrica = new FabricaDeAlumnosMuyEstudiososDecorados(); break; }
            case Fabricables.AlumnoProxy: { fabrica = new FabricaDeAlumnosProxies(); break; }
            case Fabricables.AlumnoMuyEstudiosoProxy: { fabrica = new FabricaDeAlumnosMuyEstudiososProxies(); break; }
        }

        return fabrica.CrearPorTeclado();
    }

    protected abstract Comparable CrearAleatorio();
    protected abstract Comparable CrearPorTeclado();
}