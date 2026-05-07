using Practica5.Adapter;

namespace Practica5.Command;

public class OrdenLlegaAlumno(Aula aula) : IOrdenEnAula2
{
    //variables
    private readonly Aula _aula = aula;
    
    //method
    public void Ejecutar(Comparable c) => _aula.NuevoAlumno((IAlumno)c);
}