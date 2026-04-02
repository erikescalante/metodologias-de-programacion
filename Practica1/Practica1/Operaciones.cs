namespace Practica1;

public static class Operaciones
{
    //variable
    private static readonly Random Rand = new Random();

    //methods
    
    
    //método llenar del ejercicio número x
    public static void Llenar(Coleccionable coleccion)
    {
        for (var i = 0; i < 20; i++)
        {
            Comparable c = new Numero(Rand.Next());
            coleccion.Agregar(c);
        }
    }
    
    //método informar del ejercicio número x
    public static void Informar(Coleccionable coleccion)
    {
        if (coleccion.Cuantos() == 0)
            Console.WriteLine("La colección está vacía.");
        else
        {
            Console.WriteLine($"=> cantidad de elementos: {coleccion.Cuantos()} comparables");
            var min = coleccion.Minimo();
            Console.WriteLine($"=> elemento mínimo: " + min.ToString());
            var max = coleccion.Maximo();
            Console.WriteLine($"=> elemento máximo: " + min.ToString());

            Console.WriteLine("\n*********************************************************************\n");
            Console.WriteLine("Ingrese el comparable que desea saber si se encuentra en la colección");
            Console.Write("=> ");
            var esComparable = int.TryParse(Console.ReadLine(), out var entry);

            while (!esComparable)
            {
                Console.WriteLine("\n\tEl valor ingresado es invalido. Por favor intente ingresar un valor entero.");
                Console.Write("\t=> ");
                esComparable = int.TryParse(Console.ReadLine(), out entry);
            }

            Console.Write(coleccion.Contiene(new Numero(entry))
                ? "\nEl elemento ingresado está en la colección"
                : "\nEl elemento ingresado no está en la colección");
        }
    }
    
    //método LlenaAlumnos del ejercicio 13 y su dependencia NombreAleatorio.
    public static void LlenaAlumnos(Coleccionable coleccion)
    {
        for (var i = 0; i < 20; i++)
        {
            Comparable c = new Alumno(NombreAleatorio(8), 
                new Random().Next(1000000, 99999999),
                new Random().Next(0, 99999999), 
                (decimal)new Random().Next(0, 10));
            coleccion.Agregar(c);
        }
    }

    private static string NombreAleatorio(int longitud)
    {
        const string caracteres = "abcdefghijklmnñopqrstuvwxyz";
        var resultado = new char[longitud];

        for (var i = 0; i < longitud; i++)
            resultado[i] = caracteres[Rand.Next(caracteres.Length-1)];

        return new string(resultado);
    }
}