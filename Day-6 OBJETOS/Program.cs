//Clases y objetos
    //introducción/temario:
        /*
        -Clases y objetos
        -constructores
        -propiedades
        -destructores
        -crear objetos
        */
        //Qué es una clase?
        /*
        Es el plano de un objeto.
        Tiene acciones/habilidades, llamadas funciones de miembro o métodos.
        Tienen propiedades, llamadas variables de miembro.
        Permite la herencia.
        Puede ser usada como un tipo de Datos.
        */
        //Qué es un objeto?
        /*
        -Propiedades: HP / cantidad de ruedas. Luminancia, puertas...
        -Habilidades: Conducir, frenar, abrir ventanila, encender luz...
        -Herencias: Automovil > Audi > A5
        */
//Crea un  objeto desde mi clase
//Una instancia de humano
Humano juan = new Humano("Juan","Jiménez","verdes",34);
//Accediendo a una variable pública externa

//Llamando a un método de la clase
juan.presentarse();

Humano pedro = new Humano("Julio","Perez","miel",16);
pedro.presentarse();

Humano humanoBasico = new Humano("Alberto","García","Azul");

humanoBasico.presentarse();

Humano miCombinacion = new Humano("Diego","Villaseñor");
Humano miCombinacion2 = new Humano("Rojos",17);
Humano miCombinacion2UnAnio = new Humano("Beige",1);

miCombinacion.presentarse();
miCombinacion2.presentarse();
miCombinacion2UnAnio.presentarse();

Console.ReadKey();

//Usando constructores
/*
El objetivo del constructor es disminuir el código cada vez que
creamos una nueva instancia de nuestro objeto
*/

//Modificadores de acceso
/*
Los tipos y miembros de C# cuentan con un nivel de accesibilidad,
debido a esto tenemos los modificadores de acceso.
Cada modificador de acceso establece el grado de acceso al tipo,
desde el propio proyecto o desde otro proyecto de la solución.
Esta administración permite dar mayor seguridad a los datos delimitando los accesos.

Todos los modificadores de acceso se anteponen  en la declaración del tipo
(métodos, variables, clases, etc.).

    //Public
        El acceso a estos tipos está desde el propio proyecto o desde otro sin ninguna restricción.
    //Private
        Permite el acceso solo a los miembros de la misma clase.
    //Protected
        Accesible solo a los miembros de la misma clase y de las clases hijas de este.
    //Internal
        El acceso está disponible desde cualquier clase del mismo proyecto,
        pero no de otros proyectos de la misma solución.
    //File
        el tipo declarado solo es visible en el archivo de origen actual.
        Los tipos con ámbito de archivo se usan generalmente para los generadores de origen.
    //protected internal
        El acceso está limitado al ensamblado actual o a los tipos derivados de la clase contenedora.
    //private protected
        El acceso está limitado a la clase contenedora o a los tipos derivados de la clase contenedora
        que hay en el ensamblado actual.
*/

//INSTANCIA:
    /*
    Crear un objeto a partir de una clase es lo que se llama instanciar.
    Las tres propiedades de la orientación a objetos son: encapsulación:
    Agrupar datos y códigos en una única clase.

        Es un constructor sin parámetros implícito que genera el valor predeterminado de un tipo,
        o bien un constructor sin parámetros declarado de forma explícita.
    */

    //Propiedades