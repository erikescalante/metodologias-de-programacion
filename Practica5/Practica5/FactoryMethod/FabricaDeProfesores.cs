using Practica5.Observer;

namespace Practica5.FactoryMethod;

public sealed class FabricaDeProfesores : FabricaDeComparables
{
    protected override Comparable CrearAleatorio() =>
        new Profesor(
            GeneradorDeDatosAleatorios.StringAleatorio(), 
            GeneradorDeDatosAleatorios.StringAleatorio(), 
            GeneradorDeDatosAleatorios.NumeroAleatorio(1000000, 99999999), 
            GeneradorDeDatosAleatorios.NumeroAleatorio(60)
            );

    protected override Comparable CrearPorTeclado() =>
        new Profesor(
            LectorDeDatos.StringPorTeclado(),
            LectorDeDatos.StringPorTeclado(),
            LectorDeDatos.NumeroPorTeclado(),
            LectorDeDatos.NumeroPorTeclado()
            );
}