namespace Practica2.Interfaces;

public interface IComparacion
{
    bool SosIgual(Alumno a1, Alumno a2);
    bool SosMenor(Alumno a1, Alumno a2);
    bool SosMayor(Alumno a1, Alumno a2);
}