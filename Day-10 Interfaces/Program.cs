//Interfaces
    /*
    Cuando tenemos varias clases que tienen que implementar el mismo método, por ejemplo,
    conviene usar interfaces. Las interfaces son como clases, pero en realidad no contienen
    código pues la codificación se hará en la clase donde se implementa esa interfaz.
    Entonces, lo que la interfaz contiene es las definiciones de un grupo de métodos
    o propiedades o eventos que una clase está obligada a implementar. Es una especie
    de protocolo que fuerza a las clases que heredan esa interfaz a contener aquellas
    exigencias que la interfaz está pidiendo. 
    Así como las clases pueden heredar de otras clases, también pueden heredar de una
    interfaz.
    En la interfaz se define qué queremos tener: por ejemplo métodos. Y en la clase
    que hereda esa interfaz vamos a definir el contenido de esa interfaz.
    */


//Interfaz


Notificacion n1 = new Notificacion("Fede","Como va todo","25.01.2020");
Notificacion n2 = new Notificacion("Franco","Todo bien","25.01.2020");

n1.ShowNotification();
n2.ShowNotification();

public interface INotificacion{
    void ShowNotification();
    string VerFecha();
}

//Clase
public class Notificacion:INotificacion{
    //Variables
    private string sendedBy;
    private string message;
    private string date;

    //constructor
    public Notificacion(){
        sendedBy = "Fede";
        message = "Hola";
        date = "01.01.2020";
    }

    public Notificacion (string miSendedBy, string miMessage, string miDate){
        this.sendedBy = miSendedBy;
        this.message = miMessage;
        this.date = miDate;
    }

    public void ShowNotification(){
        System.Console.WriteLine("El mensaje: {0} - fue enviado por {1} el dia {2}",message,sendedBy,date);
    }
    public string VerFecha(){
        return date;
    }
}