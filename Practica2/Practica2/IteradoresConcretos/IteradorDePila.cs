using System;
using Practica2.Interfaces;

namespace Practica2.IteradoresConcretos;

public class IteradorDePila : Iterador
{
    //variables
    private Pila _st;
    
    //constructor
    public IteradorDePila(Pila pila)
    {
        _st = pila;
    }
    
    //methods
    public void Primero(){}
    public Comparable Actual() => _st.Top();
    public void Siguiente() => _st.Pop();
    public bool Fin() => _st.IsEmpty;
}