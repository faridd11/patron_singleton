using System;
// Suggested code may be subject to a license. Learn more: ~LicenseLog:3491304843.
using System.Collections.Generic;

namespace Myapp
{

//Concret implementa la interfaz ISubject
// Suggested code may be subject to a license. Learn more: ~LicenseLog:2685638711.
public class ConcreteSubject : ISubject
{
    private List <IObserver> observer = new List<IObserver> ();
     
     //metodo para registrar un observador
     public void Attach (IObserver observer)
     {
        observers.Add(observer);
     }

     //metodo para eliminar un observador
     public void Detach (IObserver observer)
     {
        observers.Remove(observer);
     }

     //metodo para notificar a los observadores
     public void Notify(string message)
     {
        foreach (IObserver observer in observers)
        {
            observer.Update(message);
        }
     }

     //metodo para cmabiar el estado del objejto y notificar a los observadores
     public void ChangeState(string message)
     {
        Notify(message);
     }
}
}