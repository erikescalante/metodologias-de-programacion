using MetodologíasDeProgramaciónI;

namespace Practica5.Adapter;

public class EstudianteAdapter(IAlumno alumno) : Student 
{
    //variables
    private readonly IAlumno _alumno = alumno;
    
    //Student interface methods
    public string getName() => _alumno.GetNombre();
    public int yourAnswerIs(int question) => _alumno.ResponderPregunta(question);
    public void setScore(int score) => _alumno.SetCalificacion(score);
    public string showResult() => _alumno.MostrarCalificacion();
    
    /*He decidido utilizar el nombre de los estudiantes (students y estudiantes) como método de comparación
     debido a que al realizarlo utilizando los métodos propios de comparacion SosIgual(), SosMenor(), SosMayor() 
     el programa me devuelve error de incompatibilidad con los métodos del sistema MDPI (clase ListOfStudents, 
     método sort) y no encontré la manera de resolverlo... Creo que lo mejor es dejarlo de esta manera para terminar 
     con esta práctica. Más adelante me fijaré mejor cuál es exactamente el problema y trataré de arreglarlo*/
    public bool equals(Student student) => student.getName().Length == _alumno.GetNombre().Length;
    public bool lessThan(Student student) => student.getName().Length < _alumno.GetNombre().Length;

    public bool greaterThan(Student student) => student.getName().Length > _alumno.GetNombre().Length;
    
    
}