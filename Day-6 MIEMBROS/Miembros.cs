public class Miembros{
    //Crearemos todos los miembros que son reelevantes cuando
    //trabajamos con POO

        //Miembros - Campos Privado
        private string nombrePersona;
        private string tituloTrabajo;
        private int salario;

        //Miembros - Campo Público
        public int edad;

        //Miembros - Propiedades
        public string TituloTrabajo { 
            get{
                return tituloTrabajo;
            }
            set{
                tituloTrabajo=value;
            }
        }

        //Miembro -Método privado
        private void CompartirInfoPrivada(){
            Console.WriteLine("Hola, mi salario es {0}",salario);
        }

        //Miembro - Métodos Públicos
        public void Amigo(bool esAmigo){
            if(esAmigo){
                CompartirInfoPrivada();
            }else{
                Console.WriteLine("Hola, mi nombre es {0}, y mi edad es {1}",nombrePersona,edad);
            }
        }
        //Miembro - Constructor
        public Miembros(){
            edad=30;
            nombrePersona="Ana";
            salario=50000;
            tituloTrabajo="Desarrollador";
            Console.WriteLine("Objeto creado");
        }

        //Miembros-Finalizador o destructor
        ~Miembros(){
            //Limpia declaraciones
            Console.WriteLine("Destrucción de objeto miembro");
                //Debug.Write("Destrucción de objeto miembro");
            //Cuando el objeto es cerrado o eliminado o salga del alcance
            //es cuando este finalizador es ejecutado. No utilizar finalizador
            //vacío. Esto afectaría el performance innecesariamente.
        }
}