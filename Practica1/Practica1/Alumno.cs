namespace Practica1;

public sealed class Alumno : Persona
{
    //variables
    private int _legajo;
    private decimal _promedio;

    //constructor
    public Alumno(string nombre, int dni, int legajo, decimal promedio) : base(nombre, dni)
    {
        SetLegajo = legajo;
        SetPromedio = promedio;
    }

    //properties
    public int GetLegajo => _legajo;
    public decimal GetPromedio => _promedio;

    private int SetLegajo
    {
        set
        {
            ArgumentOutOfRangeException.ThrowIfNegative(value, "Legajo invalido.");
            _legajo = value;
        }
    }
    private decimal SetPromedio
    {
        set
        {
            if (value is < 0 or > 10) throw new ArgumentOutOfRangeException($"Promedio inválido. El promedio ingresado no se encuentra en el rango permitido (0-10)");
            _promedio = value;
        }
    }
    
    //methods
    //métodos sobreescritos (override methods)

    //métodos de la interfaz Comparables sobreescritos basados en el PROMEDIO de los alumnos.
    public override bool SosIgual(Comparable elem) => (elem is Alumno a && a.GetPromedio == this.GetPromedio);
    public override bool SosMayor(Comparable elem) => (elem is Alumno a && a.GetLegajo > this.GetPromedio);
    public override bool SosMenor(Comparable elem) => (elem is Alumno a && a.GetPromedio < this.GetPromedio);

    //ToString method
    public override string ToString() => $"{Nombre} - Legajo: {_legajo} - Promedio: {_promedio}";
}