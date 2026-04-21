using System;
using System.Collections.Generic;
using Practica3.Strategy;

namespace Practica3.Observer;

public class Profesor : Persona, IObservado
{
    //variables
    private int _antiguedad;
    private readonly List<IObservador?> _observadores;
    private IComparacion _estrategiaDeComparacion;
    public bool Hablando { get; private set; }

    //constructor
    public Profesor(string nombre, int dni, int antiguedad) : base(nombre, dni)
    {
        Antiguedad = antiguedad;
        _observadores = [];
        _estrategiaDeComparacion = new ComparacionPorAntiguedad();
        Hablando = false;
    }
    
    //properties
    public int Antiguedad
    {
        get { return _antiguedad; }
        private set { if (value > 0) _antiguedad = value; }
    }
    
    //methods
    private void Hablar() => Hablando = true;
    private void DejarDeHablar() => Hablando = false;
    
    public void HablarHaciaLaClase()
    {
        Console.WriteLine("Soy el profesor y le estoy Hablando a la clase");
        Hablar();
        Notificar();
    }

    public void EscribirEnPizarron()
    {
        Console.WriteLine("Soy el profesor y estoy escribiendo en el pizarrón");
        DejarDeHablar();
        Notificar();
    }
    
    //by IObservado
    public void AgregarObservador(IObservador o)
    {
        if (!_observadores.Contains(o)) 
            _observadores.Add(o);
    }

    public void QuitarObservador(IObservador o) => 
        _observadores.Remove(o);

    public void Notificar()
    {
        foreach (var observador in _observadores) 
            observador?.Actualizar(this);
    }
}