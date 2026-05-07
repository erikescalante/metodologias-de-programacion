using Practica5.Proxy;

namespace Practica5.FactoryMethod;

public class FabricaDeAlumnosProxies : FabricaDeComparables
{
    protected override Comparable CrearAleatorio() =>
        new AlumnoProxy(
            Fabricables.Alumno,
            GeneradorDeDatosAleatorios.StringAleatorio(),
            GeneradorDeDatosAleatorios.StringAleatorio(),
            GeneradorDeDatosAleatorios.NumeroAleatorio(1000000, 99999999),
            GeneradorDeDatosAleatorios.NumeroAleatorio(99999),
            GeneradorDeDatosAleatorios.NumeroAleatorio(10)
        );

    protected override Comparable CrearPorTeclado() =>
        new AlumnoProxy(
            Fabricables.Alumno,
            LectorDeDatos.StringPorTeclado(),
            LectorDeDatos.StringPorTeclado(),
            LectorDeDatos.NumeroPorTeclado(),
            LectorDeDatos.NumeroPorTeclado(),
            LectorDeDatos.NumeroPorTeclado()
        );
}