namespace Practica3;

public static class GeneradorDeDatosAleatorios
{
    //variables
    private static readonly Random Rand = new Random();
    
    //methods
    public static int NumeroAleatorio(int max) => Rand.Next(0, max);
    public static int NumeroAleatorio(int min, int max) => Rand.Next(min, max);

    public static string StringAleatorio(int longitud = 5)
    {
        const string caracteres = "abcdefghijklmnñopqrstuvwxyz";
        var resultado = new char[longitud];

        for (var i = 0; i < longitud; i++)
            resultado[i] = caracteres[Rand.Next(caracteres.Length-1)];

        return new string(resultado);
    }
}