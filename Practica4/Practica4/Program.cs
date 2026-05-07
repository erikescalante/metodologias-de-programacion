using MetodologíasDeProgramaciónI;
using Practica4.FactoryMethod;
using Practica4.Adapter;
using Practica4.Strategy;

namespace Practica4;

public static class Program
{
    /*Método Main ejercicio 4, práctica 4*/
    // public static void Main(string[] args)
    // {
    //     var teacher = new Teacher();
    //     for (var i = 0; i < 20; i++)
    //     {
    //         IAlumno estudianteAdaptar; 
    //         
    //         if(i < 10) estudianteAdaptar = (Alumno)FabricaDeComparables.CrearAleatorio(Fabricables.Alumno);
    //         else estudianteAdaptar = (AlumnoMuyEstudioso)FabricaDeComparables.CrearAleatorio(Fabricables.AlumnoMuyEstudioso);
    //         
    //         var adaptadorEstudiante = new EstudianteAdapter(estudianteAdaptar);
    //         teacher.goToClass(adaptadorEstudiante);
    //     }
    //     
    //     teacher.teachingAClass();
    //     Console.ReadKey();
    // }
    
    /*Método Main ejercicio 4, práctica 7*/
    public static void Main(string[] args)
    {
        var teacher = new Teacher();
        for (var i = 0; i < 20; i++)
        {
            IAlumno estudianteAdaptar; 
            
            if(i < 10) estudianteAdaptar = (IAlumno)FabricaDeComparables.CrearAleatorio(Fabricables.AlumnoDecorado);
            else estudianteAdaptar = (IAlumno)FabricaDeComparables.CrearAleatorio(Fabricables.AlumnoMuyEstudiosoDecorado);
            estudianteAdaptar.SetEstrategia(new ComparacionPorCalificacion());
            
            var adaptadorEstudiante = new EstudianteAdapter(estudianteAdaptar);
            teacher.goToClass(adaptadorEstudiante);
        }
        
        teacher.teachingAClass();
        Console.ReadKey();
    }
}