//Métodos: Teoría "LO MISMO QUE UNA FUNCIÓN".
    /*
    Un método es un bloque de código que contiene una serie de
    instrucciones . Un programa hace que se ejecuten las
    instrucciones al llamar al método y especificando los
    argumentos de método necesarios. En C#, todas las
    instrucciones ejecutadas se realizan en el contexto de
    un método. El método Main es el punto de entrada para cada
    aplicación de C# y se llama mediante Common Language Runtime
    (CLR) cuando se inicia el programa.
    */

    //Sintaxis:
    /*
    <especificador de acceso> <Tipo de retorno> <Nombre del método> (Lista de parámetros)
    {
        Cuerpo del Método
    }
    */

    /*
    *Especificador de acceso - Determina la visibilidad de una variable o de un
        método desde otra clase.
    *Tipo de Retorno - Un método puede devolver un valor. El tipo de retorno es el tipo
        de dato del valor  que va devolver el método. Si el método no tiene que devolver nada, el tipo de retorno es void.
    *Nombre del Método - Es un identificador único y sensible  mayúsculas. No puede
        ser iguala otro nombre de la misma clase.
    *Lista de parámetros - Encerrados entre paréntesis, los parámetros se usan para
        pasar y recibir datos en un método. La lista de parámetros se refiere al tipo,
        orden y cantidad de parámetros en un método. Los parámetros son opcionales.
        Un método puede no contener parámetros.
    *Cuerpo del Método - Contiene el conjunto de instrucciones necesarios para
        completar las actividades requeridas.

    */

    //Ejemplos:

    void EscribeAlgo() {
        Console.WriteLine("Yo nací en un método");
    }

    void EscribeAlgoEspecífico(string miTexto) {
        Console.WriteLine(miTexto);
    }

    EscribeAlgo();
    //EscribeAlgoEspecífico(Console.ReadLine());
    EscribeAlgoEspecífico("Soy un argumento y me llamaron desde un método (función).");

    //Métodos con valores de retorno y parámetros.
    static int Sumar(int num1, int num2) {
        return num1 + num2;
    }

    int resultado = Sumar(50,50);
    Console.WriteLine(resultado);

    //Desafío: Multiplicar dos valores y mostrar el resultado

    static int multiplicacion(int val1, int val2) {
        return val1 * val2;
    }

    Console.WriteLine(multiplicacion(5,5));

    static double dividir(double number1,double number2) {
        return number1 / number2;
    }

    Console.WriteLine(dividir(21,2));

    //Desafíos:
    Console.WriteLine("Desafíos: ");

    string name1 = "Edgar";
    string name2 = "Jude";
    string name3 = "Paco";

    void saludarAmigo(string friendName){
        Console.WriteLine("¡Hola {0}, que tengas un buen día!",friendName);
    }

    saludarAmigo(name1);
    saludarAmigo(name2);
    saludarAmigo(name3);

    //Ingresos del usuario
    //string input = Console.ReadLine();
    //Console.WriteLine(input);

    /*Desafío: Pedir al usuario un valor numérico, luego otro más y después
    mostrar el resultado de sumar ambos valores */

    static int SumaEntrada() {
        Console.WriteLine("Por favor, ingrese un número: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Por favor, ingrese otro número: ");
        int num2 = int.Parse(Console.ReadLine());

        int resultado = num1 + num2;
        return resultado;
    }

    //Console.WriteLine(SumaEntrada());

    //Manejor de errores con Try, Catch y Finally.
     Console.WriteLine("Por favor ingresa un número");
     string valorIngresado = Console.ReadLine();

    try{
        int valorComoInt = int.Parse(valorIngresado);
    }
    catch (FormatException){
        Console.WriteLine("El formato del valor ingresado es incorrecto");
    }
    catch (OverflowException){
        Console.WriteLine("El número ingresado es demasiado largo o demasiado corto");
    }
    catch (ArgumentNullException){
        Console.WriteLine("No se ha ingresado ningún valor");
    }
    finally{
        Console.WriteLine("Esta frase aparecerá pase lo que pase (Haya error o no)");
    }

     Console.Read();
    //El Exception solo atraparía todos los errores sin especificar alguno.
        /*Desafío: hacer un programa que divida 0 (Lo cual dará error sí o sí)
        Prevenir el error..
        */
        static void DividiendoCero(){
            int numeroUno = 5;
            int numeroDos = 0;

            try{
                int resultado = numeroUno / numeroDos;
            }
            catch (FormatException){
                Console.WriteLine("El valor ingresado no es un número");
            }
            catch (OverflowException){
                Console.WriteLine("El numero ingresado es demasiado largo o demasiado corto");
            }
            catch (ArgumentNullException){
                Console.WriteLine("No se ha ingresado ningun valor");
            }
            catch (DivideByZeroException){
                Console.WriteLine("El numero no se puede dividir entre cero");
            }
            finally{
                Console.WriteLine("Presiona Enter para continuar... ");
                Console.Read();
            }
        }

        DividiendoCero();

        //Operadores:
        /*
        Son caracteres o expresiones
        que sirven para hacer operacuiones o modificaciones en nuestros valores.
        */
            //Ejemplos:
            int numerito1 = 5;
            int numerito2 = 3;
            int numerito3;

                //Operadores unarios
                numerito3 = -numerito1; //Al asignarle el valor negativo de la variable  su valor es el opuesto.

                //De adición
                int numerito = 0;
                numerito++; //Aumenta en uno al añadir dos signos de mas
                //De substraccion
                numerito--; //Lo contrario al anterior
                //matemáticos
                int resultadito = numerito1 + numerito2;
                resultadito = numerito1 - numerito2;
                resultadito = numerito1 * numerito2;
                resultadito = numerito1 / numerito2;
                resultadito = numerito1 % numerito2; //Realiza una división y devuelve el restante

                //Relacionales
                bool esMenor;
                esMenor = numerito1 < numerito2;//False

                //Igualdad
                bool esIgual;
                esIgual = numerito1 == numerito2;//False
                esIgual = numerito1 != numerito2;//True

                //condicionales
                bool esMenorYEsIgual;

                esMenorYEsIgual = esMenor && esIgual;//False
                esMenorYEsIgual = esMenor || esIgual;//True