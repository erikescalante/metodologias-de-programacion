namespace Practica5.Command;

public interface IOrdenable
{
    void SetOrdenInicio(IOrdenEnAula1 orden);
    void SetOrdenLlegaAlumno(IOrdenEnAula2 orden);
    void SetOrdenAulaLlena(IOrdenEnAula1 orden);
}