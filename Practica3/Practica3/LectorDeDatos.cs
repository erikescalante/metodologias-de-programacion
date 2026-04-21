namespace Practica3;

public static class LectorDeDatos
{
    public static int NumeroPorTeclado()
    {
        Console.WriteLine("Ingrese un numero");
        Console.Write(">> ");

        var esNumero = int.TryParse(Console.ReadLine(), out var entry);

        while (!esNumero)
        {
            Console.WriteLine("Error en la entrada. Por favor, ingrese un numero");
            Console.Write(">> ");
            esNumero = int.TryParse(Console.ReadLine(), out entry);
        }

        return entry;
    }

    public static string StringPorTeclado()
    {
        Console.WriteLine("Ingrese una palabra");
        Console.Write(">> ");
        
        return Console.ReadLine() ?? "";
    }
}