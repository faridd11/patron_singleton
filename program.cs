namespace myapp
{
public class programas
{
    public static void Main(string[] args)
    {
        //Creamos una instancia de ConcreteSubject
        ConcreteSubject subject = new ConcreteSubject();

        //Creamos una instancia de ConcreteObserver
        ConcreteObserver observer1 = new ConcreteObserver("Observador1");
        ConcreteObserver observer2 = new ConcreteObserver("Observador2");

        //Registramos los observadores en el sujeto
        subject.Attach(observer1);
        subject.Attach(observer2);

        //Cambiamos el estado del sujeto y notificamos a los observadores
        subject.ChangeState("Mensaje1");
       

        //Eliminamos un observador
        subject.Detach(observer1);

        //Cambiamos el estado del sujeto y notificamos a los observadores restantes
        subject.ChangeState("Mensaje2");
    }
}
}