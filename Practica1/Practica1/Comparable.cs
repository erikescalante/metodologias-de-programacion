using System;

namespace Practica1;

public static partial class Program { public static void Main(string[] args) => Console.ReadKey(); }

// ReSharper disable once InconsistentNaming
public interface Comparable
{
    bool SosIgual(Comparable elem);
    bool SosMenor(Comparable elem);
    bool SosMayor(Comparable elem);
}