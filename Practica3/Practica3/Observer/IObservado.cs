namespace Practica3.Observer;

public interface IObservado
{
    void AgregarObservador(IObservador o);
    void QuitarObservador(IObservador o);
    void Notificar();
}