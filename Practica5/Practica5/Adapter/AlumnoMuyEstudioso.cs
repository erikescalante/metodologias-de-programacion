namespace Practica5.Adapter;

public class AlumnoMuyEstudioso : Alumno
{
    //constructors
    public AlumnoMuyEstudioso(string nom, string ape, int dni, int legajo, decimal promedio) 
        : base(nom, ape, dni, legajo, promedio) { }

    public AlumnoMuyEstudioso(string nom, string ape, int dni, int legajo, decimal promedio, decimal calificacion) 
        : base(nom, ape, dni, legajo, promedio, calificacion) { }
    
    public override int ResponderPregunta(int pregunta) => pregunta % 3;
}