using OneOfThree;
using System.Text.RegularExpressions;

//Modificadores de acceso
    /*
        Crear 'campos' y 'métodos' con modificadores de acceso es parte de la Programación
        Orientada a Objetos, incrementa la seguridad de tu código, y es una parte
        importante de la encapsulación (que también es una parte de OOP)

        En lenguajes de Programación Orientados a Objetos, la palabra 'encapsulación' es
        usada para referirse a una o dos nociones diferentes pero relacionadas y, a veces,
        a la combinación de ambas:
            -Un mecanismo lingüístico para restringir el acceso a alguno de los componentes
             del objeto.
            -Un constructo del lenguaje que facilita la agrupación con los métodos
             (u otras funciones) que operan en esa información.
    */
        //-Private:
            //private = solo es accesible dentro de la clase

            /*private class PrivateAccess{
                private int edad = 18;
                private void Caminar(){}
            }*/
        //-Public:
            //public = accesible desde cualquier lugar del proyecto
            /*public class PublicAccess{
                public int edad = 18;
                public void Caminar(){}
            }*/
        //-Protected:
            //protected = accesible dentro de la clase y desde clases derivadas
            /*protected class ProtectedAccess{
                protected int edad = 18;
                protected void Caminar(){}
            }*/
        //-Internal:
            //internal = accesible desde todo el ensamble (proyecto)
            /*internal class InternalAccess{
                internal int edad = 18;
                internal void Caminar(){}
            } */
    //¿Por qué?
        /*
            -Como regla general, cuando declaras una nueva clase, miembro o método, es
             recomendable comenzar desde el modificador de acceso más restrictivo que
             permita que tu programa funcione (y luego ir flexibilizando según las necesidades)
            -Te da control total sobre tus métodos y variables
        */
    //Struct
    /*
        Muy similares alas clases: son una agrupación de variables que tienen una relación
        entre sí, pero funcionan distinto en algunas cosas. Fundamentalmente es que las
        clases son de tipo de referencia y los struct son de tipo valor.
        Si creas una instancia de una clase (objeto de una clase), este puede contener nada
        y lo único que contengan sean referencias a la clase original. 
        Un struct debe tener un valor, sí o sí.
    */

    
    Game redDead;

    redDead.name = "Red Dead Redemtion 2";
    redDead.developer = "RockStar";

    redDead.Show();

    //Resumen:
    /*
         -Una clase es un tipo de referencia. Cuando se crea un objeto de la clase,
          la variable a la que se asigna el objeto contiene solo una referencia a esa memoria.
          Cuando la referencia de objeto se asigna a una nueva variable, la nueva variable
          hace referencia al objeto original. Los cambios realizados en una variable se
          reflejan en la otra variable porque ambas hacen referencia a los mismos datos.
          
         -Una estructura es un tipo de valor. Cuando se crea una estructura, la variable a la
         que se le asigna la estructura contiene los datos reales de ella. Cuando la estructura
         se asigna a una nueva variable, se copia. Por lo tanto, la nueva variable y la variable
         original contienen dos copias independientes de los mismos datos. Los cambios realizados
         en una copia no afectan a la otra copia.
    */

        /*
            --En ambos casos:
                -Son tipos de datos compuestos, usados para contener una serie de variables que tienen
                 una relación lógica entre sí.
                -Pueden contener métodos y eventos.
                -Soportan interfaces.
            --Solamente las clase:
                -Soportan herencia.
                -Son de tipo referencial.
                -Pueden tener una referencia null.
            --Solamente los struct
                -No soportan herencia.
                -Son de tipo de valor.
                -Se pasan por valor.
                -No pueden tener una referencia null.
        */

    //Enums
        /*
            Es un grupo de constantes. Es inmutable y debe ubicarse en nivel de namespace,
            para que de esta manera pueda ser usado en toda la biblioteca.
        */
            Day viernes = Day.Friday;
            Day domingo = Day.Sunday;
            Day a = Day.Friday;

            System.Console.WriteLine(viernes == a);
            System.Console.WriteLine(Day.Monday);
            System.Console.WriteLine((int)Day.Monday);

            System.Console.WriteLine("----------------------------------");

            Month first = Month.January;
            System.Console.WriteLine(Month.January==first);
            System.Console.WriteLine(Month.May);
            System.Console.WriteLine( (int)Month.December );

        /*
            Los enums, entonces, existen para almacenar y compartir constantes manteniendo,
            de esta manera, tu biblioteca consistente. Se puede usar en diferentes clase,
            y siempre tendrán el mismo valor.
        */
    
System.Console.WriteLine("__________________________________________________");

    //Math
    /*
        Es una clase especial incluida dentro de System que sirve para realizar operaciones
        matemáticas.
    */

            int aa = 13;
            int ab = 5;
            System.Console.WriteLine("El dendeo hacia arriba de 15.3 es {0}", Math.Ceiling(15.3));
            System.Console.WriteLine("El dendeo hacia abajo de 15.3 es {0}", Math.Floor(15.3));
            System.Console.WriteLine("El valor más bajo entre {0} y {1} es {2}",aa,ab, Math.Min(aa,ab) );
            System.Console.WriteLine("El valor más alto entre {0} y {1} es {2}",aa,ab, Math.Max(aa,ab) );

            System.Console.WriteLine( "3 elevado a la 5 es " + Math.Pow(3,5) );
            System.Console.WriteLine( "Pi es " + Math.PI );

            System.Console.WriteLine( "La raíz cuadrada de 25 es {0}",Math.Sqrt(25) );
            System.Console.WriteLine( "El absoluto de -25 es {0}",Math.Abs(-25) );
            System.Console.WriteLine( "El coseno de 1 es " + Math.Cos(1) );

    //Random
    /*
        Permite obtener valores al azar. En programación, eso hay que conseguirlo
        de una manera en particular.
    */
    Random dado = new Random(); //A partir de esta palabra estamos crendo una instncia de random
    int numCara;

    for (int i = 0; i < 10; i++){
        numCara = dado.Next(1,7);
        System.Console.WriteLine(numCara);
    }
        //Desafío: intenta crear un pequeño progrma "Rueda de fortuna" que responda con tres opciones a cualquier pregunta, siendo las opciones: 'Sí', 'Quizás', 'No'.

    //GameOf.ThreeAnswersGame();
    
    //Expresiones regulares
        /*
            Es un modelo con el que el motor de expresioner regulares intenta buscar una
            coincidencia en el texto de entrada.
        */
        string patron = @"\d";
        string text = "Hola, mi número telefónico es 123456";
        Regex regex = new Regex(patron);

        MatchCollection aciertos = regex.Matches(text);

        System.Console.WriteLine("{0} aciertos encontrados:\n {1}",aciertos.Count, text);

        foreach(Match acierto in aciertos){
            GroupCollection grupo = acierto.Groups;
            System.Console.WriteLine("{0} fue encontrado en {1}",grupo[0].Value, grupo[0].Index);
        }

    //Clase DateTime
        /*
            Es una clase que nos permite usar y mnipular el tiempo.
        */
        DateTime tiempo = new DateTime(1998,6,26);
        System.Console.WriteLine("Mi nacimiento fue el {0}", tiempo);

        //Mostrar fecha actual
        System.Console.WriteLine(DateTime.Today);
        //Hora actual
        System.Console.WriteLine(DateTime.Now);
        //Proximo dia
        Console.WriteLine(WorkingTime.ComingDay());
        //Dia de la semana
        System.Console.WriteLine( DateTime.Today.DayOfWeek );
        //Primer dia del año
        System.Console.WriteLine( WorkingTime.FistDayOfYear(1998) );
        //Cuantos dias hay en un mes en particular
        int diass = DateTime.DaysInMonth(1998,2);
        System.Console.WriteLine(diass);
        //Minuto
        DateTime ahora = DateTime.Now;
        System.Console.WriteLine(ahora.Minute);

        //Desafío: "En este momento son las {0} horas, {1} minutos y {2} segundos."
        System.Console.WriteLine( "En este momento son las {0} horas, {1} minutos y {2} segundos.", DateTime.Now.Hour,DateTime.Now.Minute,DateTime.Now.Second );

        //Programa para contar cuantos dias hay entre hoy y cualquier fecha en el futuro.
        System.Console.WriteLine( "Por favor, ingrese una fecha en el siguiente formato: aaaa-mm-dd" );
        string ingreso = Console.ReadLine();
        if(DateTime.TryParse(ingreso, out tiempo)){
            System.Console.WriteLine(tiempo);
            TimeSpan diasEnteros=ahora.Subtract(tiempo);
            System.Console.WriteLine("Dias que pasaron desde esa fecha {0}",diasEnteros.Days);
        }else{ System.Console.WriteLine("Ingreso incorrecto"); }
    
    //Nulabilidad
        /*
            
        */
        int? num1 = null; //Esto le asigna nulabilidad, o la habilidad de tener un valor nulo
        int? num2 = 1337;
        int? num5 = null;

        double? num3 = new Double?();
        double? num4 = 3.14;

        bool? valor = new bool?();

        System.Console.WriteLine("Nuestros valores son: {0}, {1}, {2}, {3}, {4} ",num1,num2,num3,num4,num5);
        System.Console.WriteLine("Nuestro bool es: {0} ",valor);

        bool? esHombre = null;

        if(esHombre == true){
            System.Console.WriteLine("El usuario es hombre");
        } else if( esHombre == false ){
            System.Console.WriteLine("El usuario es mujer");
        }else{
            System.Console.WriteLine("No se especificó género");
        }

        double? num6 = 13.1;
        double? num7 = null;
        double num8;

        if(num6==null){
            num8=0.00;
        }else{
            num8 = (double)num6;
        }

        System.Console.WriteLine("El valor de num8 es " + num8);

        num8 = num6 ?? 8.53; // El operador de doble signo (??) se fija si a la izquierda el valor es nulo, asigna el valor de la derecha. Si no, se asigna el de la izquierda.

        System.Console.WriteLine("El valor de num8 es " + num8);

    