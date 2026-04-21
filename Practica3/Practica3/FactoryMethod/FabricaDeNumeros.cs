namespace Practica3.FactoryMethod;

public sealed class FabricaDeNumeros : FabricaDeComparables
{
    protected override Comparable CrearAleatorio() =>
        new Numero(GeneradorDeDatosAleatorios.NumeroAleatorio(int.MaxValue));

    protected override Comparable CrearPorTeclado() =>
        new Numero(LectorDeDatos.NumeroPorTeclado());
}