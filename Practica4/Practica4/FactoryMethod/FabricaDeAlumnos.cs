namespace Practica4.FactoryMethod;

public class FabricaDeAlumnos : FabricaDeComparables
{
    protected override Comparable CrearAleatorio() =>
        new Alumno(
            GeneradorDeDatosAleatorios.StringAleatorio(),
            GeneradorDeDatosAleatorios.StringAleatorio(),
            GeneradorDeDatosAleatorios.NumeroAleatorio(1000000, 99999999),
            GeneradorDeDatosAleatorios.NumeroAleatorio(99999),
            GeneradorDeDatosAleatorios.NumeroAleatorio(10)
            );

    protected override Comparable CrearPorTeclado() =>
        new Alumno(
            LectorDeDatos.StringPorTeclado(),
            LectorDeDatos.StringPorTeclado(),
            LectorDeDatos.NumeroPorTeclado(),
            LectorDeDatos.NumeroPorTeclado(),
            LectorDeDatos.NumeroPorTeclado()
            );
}