namespace Myapp
{

//ConcreteObserver implementa la interfaz IObserver
public class ConcreteObserver : IObserver
{
    private string name;

    //El constructor recibe el nombre del observador
    public ConcreteObserver (string name)
    {
        this.name = name;
    }
    //IMplementacion del metodo update que recibe la notificacion del sujeto
    public void Update(string message)
    {
        Console.WriteLine("Observador"+ name + " recibio mensaje: " + message);
    }
}
}