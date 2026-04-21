namespace Practica3.FactoryMethod;

public sealed class FabricaDeAlumnos : FabricaDeComparables
{
    protected override Comparable CrearAleatorio() =>
        new Alumno(
            GeneradorDeDatosAleatorios.StringAleatorio(),
            GeneradorDeDatosAleatorios.NumeroAleatorio(1000000, 99999999),
            GeneradorDeDatosAleatorios.NumeroAleatorio(99999),
            GeneradorDeDatosAleatorios.NumeroAleatorio(10)
            );

    protected override Comparable CrearPorTeclado() =>
        new Alumno(
            LectorDeDatos.StringPorTeclado(),
            LectorDeDatos.NumeroPorTeclado(),
            LectorDeDatos.NumeroPorTeclado(),
            LectorDeDatos.NumeroPorTeclado()
            );
}