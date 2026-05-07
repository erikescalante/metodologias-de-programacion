using MetodologíasDeProgramaciónI;
using Practica5.Adapter;

namespace Practica5;

public class Aula
{
    //variables
    private Teacher? _teacher;
    
    //methods
    public void Comenzar()
    {
        _teacher = new Teacher();
        Console.WriteLine("El profesor ha llegado, la clase comienza.");
    }

    public void NuevoAlumno(IAlumno alumno)
    {
        Student alumnoAdaptado = new EstudianteAdapter(alumno);
        _teacher?.goToClass(alumnoAdaptado);
        Console.WriteLine($"El alumno {alumnoAdaptado.getName()} ha ingresado al aula.");
    }

    public void ClaseLista()
    {
        Console.WriteLine("Clase lista. El salón está lleno");
        _teacher?.teachingAClass();
        Console.WriteLine("Clase finalizada.");
    }
}