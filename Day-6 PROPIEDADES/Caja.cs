//Propiedades
    //Miembros variables
public class Caja{
    private int largo;
    private int alto;
    //private int ancho;
    private int volumen;

    public Caja(int largo,int alto,int ancho){
        this.largo = largo;
        this.alto=alto;
        this.Ancho=ancho;
    }

    public int Volumen { 
        set {
            volumen = value;
        }
        get {
            return Alto * Ancho * largo;
        }
        }

public int Alto {
    get{
        return alto;
    }
    set{ //Podría funcionar solo con el get sin la función setter pero no habría la posibilidad de asignarle valor
        if(value <0 ) { //value = -value //Esto le asigna el valor contrario por lo que if (el valor es negativo) se convierte automáticamente en valor positivo.
            throw new Exception("El tamaño debe ser positivo");
        } else {
            alto = value;
        }
    }
    }

public int SuperficieFrontal{
    get{
        return Alto*Largo;
    }
}

//Crear propiedad de la manera corta (propiedad Auto-Implementada);

public int Ancho { get; set; }

//Crear una propiedad de la manera larga
    /*public int Largo{
        get{
            return largo;
        }
        set{
            largo=value;
        }
    } */

    public int Largo{
        get =>largo;
        set=>largo=value;
    }

        //Miembro método
    public void MuestraInfo(){
    Console.WriteLine("El largo es {0}. La altura es {1}. El ancho es {2}. Por lo tanto el volumen es {3}. "
    ,largo,alto,Ancho,volumen=Ancho*alto*largo); //En Ancho se utiliza la propiedad como variable.
    }

    /* public void SetLargo(int largo){
        this.largo=largo;
    }
    public int GetLargo(){
        return this.largo;
    }*/

}