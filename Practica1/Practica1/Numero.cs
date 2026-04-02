using System;
namespace Practica1;

public class Numero(int valor) : Comparable
{
    //properties
    public int GetValor => valor; 
    
    //methods
    public bool SosIgual(Comparable elem) => (elem is Numero n && n.GetValor == this.GetValor);
    public bool SosMenor(Comparable elem) => (elem is Numero n && n.GetValor < this.GetValor);
    public bool SosMayor(Comparable elem) => (elem is Numero n && n.GetValor > this.GetValor);
    
    //ToString() method
    public override string ToString() => valor.ToString();
}