using System;
using Practica2.Interfaces;

namespace Practica2;

public abstract class Persona : Comparable
{
    //variables
    protected readonly string Nombre;
    protected int Dni;

    //constructor
    protected Persona(string nombre, int dni)
    {
        Nombre = nombre;
        SetDni = dni;
    }
    
    //properties
    protected int SetDni
    {
        set
        {
            if (value < 0 || (value.ToString().Length is > 8 or < 7))
                throw new ArgumentOutOfRangeException($"Entrada invalida. Dni fuera de rango.");
            Dni = value;
        }
    }
    public string GetNombre => Nombre;
    public int GetDni => Dni;
    
    //methods 
    
    //Métodos de la interfaz Comparable
    public virtual bool SosIgual(Comparable elem) => (elem is Persona p && p.GetDni == this.GetDni);
    public virtual bool SosMenor(Comparable elem) => (elem is Persona p && p.GetDni < this.GetDni);
    public virtual bool SosMayor(Comparable elem) => (elem is Persona p && p.GetDni > this.GetDni);
    
    //ToString() method
    public override string ToString() => $"{Nombre} - Dni: {Dni}";
}