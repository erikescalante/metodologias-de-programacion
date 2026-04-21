using System;

namespace Practica3.FactoryMethod;

public abstract class FabricaDeComparables
{
    public static Comparable CrearAleatorio(Fabricables fabricable)
    {
        FabricaDeComparables fabrica = new FabricaDeNumeros();

        switch (fabricable)
        {
            case Fabricables.Numero: { break; }
            case Fabricables.Alumno: { fabrica = new FabricaDeAlumnos(); break; }
            case Fabricables.Profesor: { fabrica = new FabricaDeProfesores(); break; }
        }

        return fabrica.CrearAleatorio();
    }

    public static Comparable CrearPorTeclado(Fabricables fabricable)
    {
        FabricaDeComparables fabrica = new FabricaDeNumeros();

        switch (fabricable)
        {
            case Fabricables.Numero: { break; }
            case Fabricables.Alumno: { fabrica = new FabricaDeAlumnos(); break; }
            case Fabricables.Profesor: { fabrica = new FabricaDeProfesores(); break; }
        }

        return fabrica.CrearPorTeclado();
    }

    protected abstract Comparable CrearAleatorio();
    protected abstract Comparable CrearPorTeclado();
}