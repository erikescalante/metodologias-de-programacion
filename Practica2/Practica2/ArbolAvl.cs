using System;
using Practica2.Interfaces;

namespace Practica2;

public sealed class ArbolAvl
{
    //variables 
    private readonly Comparable _dato;
    private ArbolAvl? _hijoIzquierdo;
    private ArbolAvl? _hijoDerecho;
    private int _altura;
    public Comparable Minimo { get; private set; }
    public Comparable Maximo { get; private set; }


    //constructor
    public ArbolAvl(Comparable dato)
    {
        _dato = dato;
        Minimo = dato;
        Maximo = dato;
        _altura = 0;
    }
    
    //methods
    
    private Comparable Getdato() => _dato;
    
    private void AgregarHijoIzq(ArbolAvl? hijo) => _hijoIzquierdo= hijo;
    private ArbolAvl? GetHijoIzq() => _hijoIzquierdo;
    
    private void AgregarHijoDer(ArbolAvl? hijo) => _hijoDerecho = hijo;
    private ArbolAvl? GetHijoDer() => _hijoDerecho;
    
    private void BorrarHijoIzq() => _hijoIzquierdo = null;
    private void BorrarHijoDer() => _hijoDerecho = null;
		
    public bool Incluido(Comparable elemento)
    {
        if (_dato.SosIgual(elemento)) return true;
        if (_dato.SosMenor(elemento)) return GetHijoIzq()?.Incluido(elemento) ?? false;
        return GetHijoDer()?.Incluido(elemento) ?? false;
    }

    private int GetAltura() => _altura;

    private void ActualizarAltura()
    {
        var alturaIzq = _hijoIzquierdo?.GetAltura() ?? -1;
        var alturaDer = _hijoDerecho?.GetAltura() ?? -1;
        _altura = (alturaIzq > alturaDer) ? alturaIzq + 1 : alturaDer + 1;
    }
    
    public ArbolAvl Agregar(Comparable elemento)
    {
        if (elemento.SosMayor(_dato)) AgregarHijoDer(_hijoDerecho == null ? new ArbolAvl(elemento) : _hijoDerecho.Agregar(elemento));
        else AgregarHijoIzq(_hijoIzquierdo == null ? new ArbolAvl(elemento) : _hijoIzquierdo.Agregar(elemento));
        
        ActualizarAltura();

        var newRoot = this;
        var balance = (_hijoDerecho?.GetAltura() ?? -1) - (_hijoIzquierdo?.GetAltura() ?? -1);

        if (balance >= 2) newRoot = elemento.SosMayor(_hijoDerecho!.Getdato()) ? Srr() : Drr();
        else if (balance <= -2) newRoot = !elemento.SosMayor(_hijoIzquierdo!.Getdato()) ? Slr() : Dlr();
        if (Minimo.SosMenor(elemento)) Minimo = elemento;
        if (Maximo.SosMayor(elemento)) Maximo = elemento;
        return newRoot;
    }

    private ArbolAvl Slr()
    {
        //rotation logic
        var newRoot = GetHijoIzq();
        AgregarHijoIzq(newRoot?.GetHijoDer() ?? null);
        newRoot!.AgregarHijoDer(this);
        
        //altura update
        ActualizarAltura();
        newRoot.ActualizarAltura();
        
        //value to use in the add and remove methods
        return newRoot;
    }
    
    private ArbolAvl Srr()
    {
        //rotation logic
        var newRoot = GetHijoDer();
        AgregarHijoDer(newRoot?.GetHijoIzq() ?? null);
        newRoot!.AgregarHijoIzq(this);
        
        //altura update
        ActualizarAltura();
        newRoot.ActualizarAltura();
        
        //value to use in the add and remove methods
        return newRoot;
    }
    
    private ArbolAvl Dlr()
    {
        AgregarHijoDer(GetHijoDer()!.Slr());
        return Srr();
    }
    
    private ArbolAvl Drr()
    {
        AgregarHijoIzq(GetHijoIzq()!.Srr());
        return Slr();
    }
}
