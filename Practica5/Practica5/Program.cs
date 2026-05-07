using Practica5.FactoryMethod;
using Practica5.Command;

namespace Practica5;

public static class Program
{
    /*Método Main ejercicio 2, práctica 5*/
    // public static void Main(string[] args)
    // {
    //     var teacher = new Teacher();
    //     for (var i = 0; i < 20; i++)
    //     {
    //         IAlumno estudianteAdaptar; 
    //         
    //         if(i < 10) estudianteAdaptar = (AlumnoProxy)FabricaDeComparables.CrearAleatorio(Fabricables.AlumnoProxy);
    //         else estudianteAdaptar = (AlumnoProxy)FabricaDeComparables.CrearAleatorio(Fabricables.AlumnoMuyEstudiosoProxy);
    //         
    //         var adaptadorEstudiante = new EstudianteAdapter(estudianteAdaptar);
    //         teacher.goToClass(adaptadorEstudiante);
    //     }
    //     
    //     teacher.teachingAClass();
    //     Console.ReadKey();
    // }
    
    /*Método Main ejercicio 10, practica 5*/
    public static void Main(string[] args)
    {
        var pila = new Pila(40);
        var aula = new Aula();
        
        pila.SetOrdenInicio(new OrdenInicio(aula));
        pila.SetOrdenLlegaAlumno(new OrdenLlegaAlumno(aula));
        pila.SetOrdenAulaLlena(new OrdenAulaLlena(aula));
        
        Operaciones.Llenar(pila, Fabricables.Alumno);
        Operaciones.Llenar(pila, Fabricables.AlumnoMuyEstudioso);
    }
}