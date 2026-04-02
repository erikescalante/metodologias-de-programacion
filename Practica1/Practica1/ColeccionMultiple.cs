namespace Practica1;

public class ColeccionMultiple(Pila pila, Cola cola) : Coleccionable
{
    //methods
    
    //methods from interface Comparable
    public int Cuantos() => pila.Cuantos() + cola.Cuantos();

    public Comparable Minimo()
    {
        var minPila = (pila.Cuantos() == 0) ? null : pila.Minimo();
        var minCola = (cola.Cuantos() == 0) ? null : cola.Minimo();

        if (minPila is null & minCola is null) 
            throw new NullReferenceException($"internal queue and stack from << {this} >> are empty.");

        if (minPila is null) return minCola!;
        if (minCola is null) return minPila;
        return (minPila.SosMenor(minCola)) ? minCola : minPila;
    }

    public Comparable Maximo()
    {
        var maxPila = (pila.Cuantos() == 0) ? null : pila.Maximo();
        var maxCola = (cola.Cuantos() == 0) ? null : cola.Maximo();

        if (maxPila is null & maxCola is null) 
            throw new NullReferenceException($"internal queue and stack from << {this} >> are empty.");

        if (maxPila is null) return maxCola!;
        if (maxCola is null) return maxPila;
        return (maxPila.SosMayor(maxCola)) ? maxCola : maxPila;
    }

    public void Agregar(Comparable elem)
    {
        throw new NotImplementedException();
    }

    public bool Contiene(Comparable elem) => (pila.Contiene(elem) || cola.Contiene(elem));
}