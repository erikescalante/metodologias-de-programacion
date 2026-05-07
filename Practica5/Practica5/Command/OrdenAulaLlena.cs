namespace Practica5.Command;

public class OrdenAulaLlena(Aula aula) : IOrdenEnAula1
{
    //variables 
    private readonly Aula _aula = aula;
    
    //method
    public void Ejecutar() => _aula.ClaseLista();
}