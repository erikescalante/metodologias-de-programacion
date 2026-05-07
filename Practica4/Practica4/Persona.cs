namespace Practica4;

public abstract class Persona : Comparable
{
    //variables
    protected readonly string Nombre;
    protected readonly string Apellido;
    protected int Dni;

    //constructor
    protected Persona(string nombre, string apellido, int dni)
    {
        Nombre = nombre;
        Apellido = apellido;
        SetDni = dni;
    }
    
    //properties
    private int SetDni
    {
        set
        {
            if (value < 0 || (value.ToString().Length is > 8 or < 7))
                throw new ArgumentOutOfRangeException($"Entrada invalida. Dni fuera de rango.");
            Dni = value;
        }
    }
    
    //methods 
    public string GetNombre() => Nombre;
    public string GetApellido() => Apellido;
    public int GetDni() => Dni;
    
    //Métodos de la interfaz Comparable
    public virtual bool SosIgual(Comparable elem) => (elem is Persona p && p.GetDni() == this.GetDni());
    public virtual bool SosMenor(Comparable elem) => (elem is Persona p && p.GetDni() < this.GetDni());
    public virtual bool SosMayor(Comparable elem) => (elem is Persona p && p.GetDni() > this.GetDni());
    
    //ToString() method
    public override string ToString() => $"{Nombre} - Dni: {Dni}";
}