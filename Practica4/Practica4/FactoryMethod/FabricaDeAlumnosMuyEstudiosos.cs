using Practica4.Adapter;

namespace Practica4.FactoryMethod;

public class FabricaDeAlumnosMuyEstudiosos : FabricaDeAlumnos
{
    protected override Comparable CrearAleatorio() =>
        new AlumnoMuyEstudioso(
            GeneradorDeDatosAleatorios.StringAleatorio(),
            GeneradorDeDatosAleatorios.StringAleatorio(),
            GeneradorDeDatosAleatorios.NumeroAleatorio(1000000, 99999999),
            GeneradorDeDatosAleatorios.NumeroAleatorio(99999),
            GeneradorDeDatosAleatorios.NumeroAleatorio(10)
        );

    protected override Comparable CrearPorTeclado() =>
        new AlumnoMuyEstudioso(
            LectorDeDatos.StringPorTeclado(),
            LectorDeDatos.StringPorTeclado(),
            LectorDeDatos.NumeroPorTeclado(),
            LectorDeDatos.NumeroPorTeclado(),
            LectorDeDatos.NumeroPorTeclado()
        );
}