using Practica5.Adapter;
using Practica5.Command;
using Practica5.Iterator;

namespace Practica5;

public sealed class Pila : Coleccionable, IOrdenable
{
    //variables
    private readonly List<Comparable?> _elementos;
    
    private IOrdenEnAula1? _ordenInicio, _ordenAulaLlena;
    private IOrdenEnAula2? _ordenLlegaAlumno;
    
    //constructor
    public Pila() => _elementos = [];

    public Pila(int capacidad)
    {
        ArgumentOutOfRangeException.ThrowIfNegative(capacidad, "Entrada inválida. No existe la capacidad negativa");
        _elementos = new List<Comparable?>(capacidad);
    }
    
    //methods
    public bool IsEmpty => (_elementos.Count == 0);
    
    public Comparable? Top() => (this.IsEmpty) 
        ? throw new NullReferenceException("Pila vacía")
        :_elementos[^1] ;
    
    public Comparable? Pop()
    {
        if (_elementos.Count == 0) throw new NullReferenceException("Pila vacía");
        
        var top = _elementos[^1];
        _elementos.RemoveAt(_elementos.Count - 1);
        return top;
    }

    private void Push(Comparable elem)
    {
        _elementos.Add(elem);
        if (elem is not IAlumno) return;
        
        if (_elementos.Count == 1 && _ordenInicio is not null) _ordenInicio.Ejecutar();
        if (_ordenLlegaAlumno is not null) _ordenLlegaAlumno.Ejecutar(elem);
        if (_elementos.Count >= 40 && _ordenAulaLlena is not null) _ordenAulaLlena.Ejecutar(); 
    }
    //methods by Comparable interface.
    public int Cuantos() => _elementos.Count;

    public Comparable? Minimo()
    {
        ArgumentOutOfRangeException.ThrowIfZero(_elementos.Count, "Pila vacía");

        var minimo = _elementos[0];
        foreach (var i in _elementos)
        {
            if (i is null) continue;
            if (minimo is null || minimo.SosMenor(i)) minimo = i;
        }

        return minimo;
    }

    public Comparable? Maximo()
    {
        ArgumentOutOfRangeException.ThrowIfZero(_elementos.Count, "Pila vacía");

        var maximo = _elementos[0];
        foreach (var i in _elementos)
        {
            if (i is null) continue;
            if (maximo is null || maximo.SosMayor(i)) maximo = i;
        }

        return maximo;    
    }

    public void Agregar(Comparable elem) => Push(elem);

    public bool Contiene(Comparable elem)
    {
        foreach (var i in _elementos)
        {
            if (i is null) continue;
            if (i.SosIgual(elem)) return true;
        }
        
        return false;
    }
    
    //methods by Iterable interface
    
    public IIterador CrearIterador() => new IteradorDePila(this);
    
    //methods by IOrdenable interface
    public void SetOrdenInicio(IOrdenEnAula1 orden) => _ordenInicio = orden;

    public void SetOrdenLlegaAlumno(IOrdenEnAula2 orden) => _ordenLlegaAlumno = orden;

    public void SetOrdenAulaLlena(IOrdenEnAula1 orden) => _ordenAulaLlena = orden;
}
