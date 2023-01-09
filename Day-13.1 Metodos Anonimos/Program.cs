//Metodos anonimos.
    /*
    Esto es cuando tenemos un método que no tiene nombre.
    Es muy útil cuando el usuario quiere crear un método en línea y cundo quiere pasar parámetros
    en el método anónimo como otros métodos.
    La idea es hacer el código más liviano, que todo sea más conciso; porque  veces sucede
    que tienes un método que solo se utiliza una sola vez, y en ess ocsiones tendría más sentido
    crer el método como anónimo, porque ya nunca vas a volver a llamarlo.
    Es una característica que es muy útil pra usar, por ejemplo, en eventos y que se usa un poco
    en elemtos de interfaz de usuario, en WPF, y es por eso que conviene comprenderlo antes de 
    de entrar en estos temas. 
    */

        //Puntos importantes:
            /*
                -Los métodos con nombres siempre se compilan primero antes que los nombrados
            */

    static void MyMain(){
        ObtenerDelegadoTexto miDelegado = delegate(string nombre){
            return "Hola, " + nombre;
        };
        System.Console.WriteLine(miDelegado("Fede"));
        Mostrar(miDelegado);
    }

    MyMain();

    static void Mostrar(ObtenerDelegadoTexto miDelegado){
        System.Console.WriteLine(miDelegado("Mundo"));
    }

    static void DecirHola(){
        System.Console.WriteLine("Hola");
    }

    public delegate string ObtenerDelegadoTexto(string nombre);