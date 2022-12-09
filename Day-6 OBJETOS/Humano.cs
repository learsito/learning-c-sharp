//Miembro variable
public class Humano {
    private string primerNombre = "";
    private string apellido = "";
    private string colorDeOjos = "";
    private int edad = 0;

    //Constructor no parametrizado o por defecto
    public Humano(){
        Console.WriteLine("Constructor llamado. Objeto creado");
    }

    //Mi miembro constructor parametrizado
    public Humano (string miPrimerNombre, string apellido, string colorDeOjos, int edad){
        primerNombre = miPrimerNombre; //Una manera de hacerlo
        this.apellido = apellido; //Segunda manera de hacerlo
        this.colorDeOjos = colorDeOjos;
        this.edad = edad;
    }

    public Humano (string miPrimerNombre, string apellido, string colorDeOjos){
        primerNombre = miPrimerNombre; //Una manera de hacerlo
        this.apellido = apellido; //Segunda manera de hacerlo
        this.colorDeOjos = colorDeOjos;
    }

    public Humano (string primerNombre, string apellido){
        this.primerNombre = primerNombre;
        this.apellido = apellido;
    }

    public Humano(string colorDeOjos,int edad){
        this.colorDeOjos = colorDeOjos;
        this.edad = edad;
    }

    //SE PUEDEN CREAR TANTOS CONSTRUCTORES COMO QUIERAS//

    //Miembro Método
    public void presentarse(){

        if (edad==1){

            if( primerNombre!="" && apellido != "" && colorDeOjos != "" ){
                Console.WriteLine("Hola, soy {0} {1}, tengo los ojos {2} y tengo {3} año de edad."
                ,primerNombre, apellido,colorDeOjos,edad);
            } else {
                Console.WriteLine("Hola, tengo los ojos {0} y tengo {1} año de edad."
                ,colorDeOjos,edad);
            }
        } else if(edad!=0) {
            if( primerNombre!="" && apellido != "" && colorDeOjos != "" ){
                Console.WriteLine("Hola, soy {0} {1}, tengo los ojos {2} y tengo {3} años de edad."
                ,primerNombre, apellido,colorDeOjos,edad);
            } else {
                Console.WriteLine("Hola, tengo los ojos {0} y tengo {1} años de edad."
                ,colorDeOjos,edad);
            }
        } else {
            
            if (primerNombre !="" && apellido != "" && colorDeOjos != "") {
                Console.WriteLine("Hola, soy {0} {1}, tengo los ojos {2}."
                ,primerNombre, apellido,colorDeOjos);
            } else {
                Console.WriteLine("Hola, soy {0} {1}."
                ,primerNombre, apellido);
            }
        }
    }
}

//Propiedades
