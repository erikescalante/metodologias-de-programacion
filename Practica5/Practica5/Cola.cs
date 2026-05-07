using Practica5.Adapter;
using Practica5.Command;
using Practica5.Iterator;

namespace Practica5;

public sealed class Cola : Coleccionable, IOrdenable
{
    //variables
    private readonly LinkedList<Comparable?> _elementos = [];
    
    private IOrdenEnAula1? _ordenInicio, _ordenAulaLlena;
    private IOrdenEnAula2? _ordenLlegaAlumno;
    //properties
    public bool IsEmpty => _elementos.Count == 0;
    
    //methods
    public Comparable? Peek() => (this.IsEmpty)
        ? throw new NullReferenceException("Cola vacía")
        : _elementos.First();
    
    public Comparable? Dequeue()
    {
        if (this.IsEmpty) throw new NullReferenceException("Cola vacía");
        
        var top = _elementos.First();
        _elementos.RemoveFirst();
        return top;
    }

    private void Enqueue(Comparable elem)
    {
        _elementos.AddLast(elem);
        if (elem is not IAlumno) return;
        
        if (_elementos.Count == 1 && _ordenInicio is not null) _ordenInicio.Ejecutar();
        if (_ordenLlegaAlumno is not null) _ordenLlegaAlumno.Ejecutar(elem);
        if (_elementos.Count >= 40 && _ordenAulaLlena is not null) _ordenAulaLlena.Ejecutar(); 
    }

    //methods from Comparable interface.
    
    public int Cuantos() => _elementos.Count;

    public Comparable? Minimo()
    {
        ArgumentOutOfRangeException.ThrowIfZero(_elementos.Count, "Cola vacía");

        var minimo = _elementos.First();
        foreach (var i in _elementos)
        {
            if (i is null) continue;
            if (minimo is null || minimo.SosMenor(i)) minimo = i;
        }

        return minimo;
    }

    public Comparable? Maximo()
    {
        ArgumentOutOfRangeException.ThrowIfZero(_elementos.Count, "Cola vacía");

        var maximo = _elementos.First();
        foreach (var i in _elementos)
        {
            if (i is null) continue;
            if (maximo is null || maximo.SosMayor(i)) maximo = i;
        }

        return maximo;
    }

    public void Agregar(Comparable elem) => Enqueue(elem);

    public bool Contiene(Comparable elem)
    {
        foreach (var i in _elementos)
        {
            if (i is null) continue;
            if (i.SosIgual(elem)) return true;
        }
        
        return false;
    }
    
    //method by Iterable interface
    public IIterador CrearIterador() => new IteradorDeCola(this);
    
    //methods by IOrdenable interface
    public void SetOrdenInicio(IOrdenEnAula1 orden) => _ordenInicio = orden;

    public void SetOrdenLlegaAlumno(IOrdenEnAula2 orden) => _ordenLlegaAlumno = orden;

    public void SetOrdenAulaLlena(IOrdenEnAula1 orden) => _ordenAulaLlena = orden;
}