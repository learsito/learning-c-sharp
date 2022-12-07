//Declaración if
    /*
    if (condición){
        Lo que hay que hacer si la condición se cumple
    }
    else if (){
        Lo que hay que hacer si la condición 2 se cumple
    }
    else{
        Lo que hay que hacer si ninguna condición se cumple
    }
    */
    //Ejemplo:
    static void EnterToContinue(string statement = ""){
        if(statement!=""){
            WritingLine(statement);
        }
        WritingLine("Presiona Enter para continuar...");
        Console.Read();
    }

    static void WritingLine(string statement){
        Console.WriteLine(statement);
    }

    static string ReadingLine(){
        string statement = Console.ReadLine();
        return statement;
    }

    static void WhatToDress(){
    WritingLine("¿Cuál es la temperatura? ");
    int temperatura = int.Parse(Console.ReadLine());

    if (temperatura <= 15){
        WritingLine("Deberías abrigarte.");
    }
    else if(temperatura >15 && temperatura < 25){
        WritingLine("Puedes vestirte normal.");
    }
    else if(temperatura >=25 && temperatura < 35){
        WritingLine("Deberías usar ropa fresca.");
    }
    else{
        WritingLine("Probablemente mueras achicharrado.");
    }
}

//Método TryParse:
    /*
    Con el método TryParse() puedes convertir un string como
    "128" en un tipo de dato numérico, como un int
    */
    //Ejemplo:

    static void ParsingExample(){
        string numeroComoString = "128";
        int valorParseado;

        bool exito = int.TryParse(numeroComoString, out valorParseado); //Después del out indica que si es parseable, el valor se hará parse y se almacenará en la variable que viene después.
        //El valor booleano de retorno será true si Parse es posible.

        if(exito || int.TryParse(numeroComoString, out valorParseado)){
            WritingLine("¡Parsing fué exitoso! El número es: "+valorParseado);
        } else{
            WritingLine("Parsing fallido.");
        }
    }

    static void AnidatedConditionals(){
        bool esAdmin = false;
        bool estaRegistrado = true;
        string nombreDeUsuario = "";

        WritingLine("Por favor, ingrese su nombre de usuario: ");
        nombreDeUsuario = ReadingLine();
        if(estaRegistrado){
            WritingLine("Hola usuario registrado");
            if(nombreDeUsuario != ""){
                WritingLine("Hola "+nombreDeUsuario);
                if(nombreDeUsuario.Equals("Admin")){ //Con el signo == comparamos integers. Aquí se comparan strings. Los string se deben comparar a través del método Equals("string");
                    WritingLine("Hola Admin");
                }
            }
        }
    }

    static void ConditionalInOneLine(){
        bool esAdmin = false;
        bool estaRegistrado = true;
        string nombreDeUsuario = "";

        WritingLine("Por favor, ingrese su nombre de usuario: ");
        nombreDeUsuario = ReadingLine();

        if(estaRegistrado && nombreDeUsuario != "" && nombreDeUsuario.Equals("Admin")){
            WritingLine("Hola usuario registrado!");
            WritingLine("¡Hola " + nombreDeUsuario + "!");
            WritingLine("¡Hola querido Administrador!");
        }

        if(esAdmin || estaRegistrado){
            WritingLine("Estás logueado");
        }
        EnterToContinue();
    }

    static void UserLogIn(){
        WritingLine("Elige un nombre de usuario: ");
        string userName = ReadingLine();
        EnterToContinue("Tu nombre de usuario se ha guardado exitosamente.");
        WritingLine("Crea una contraseña: ");
        string userPass = ReadingLine();
        userPass = ReadingLine();
        EnterToContinue("Tu contraseña se ha guardado exitosamente.");

        WritingLine("Ahora inicia sesión. Por favor ingresa tu nombre de usuario: ");
        string userNameTyped = ReadingLine();
        userNameTyped = ReadingLine();
        WritingLine("Ingresa la contraseña: ");
        string UserPassTyped = ReadingLine();

        if (userNameTyped == userName && UserPassTyped == userPass) {
            WritingLine("¡Inicio de sesión exitoso!");
            WritingLine("¡Bienvenido, " + userName + "!");
            EnterToContinue();
        } else if (userNameTyped != userName){
            EnterToContinue("El nombre de usuario no es correcto");
        } else if (userNameTyped == userName && UserPassTyped != userPass) {
            EnterToContinue("La contraseña es incorrecta.");
        } else {
            EnterToContinue("Ha habido un error. Por favor, vuelve a intentarlo.");
        }

    }

    static void SwitchStatement(){
        int autos =5;

        switch (autos){
            case 0:
                WritingLine("Usted no paga impuestos");
                break;
            case 1:
                WritingLine("Usted paga $15");
                break;
            case 2:
                WritingLine("Usted paga $30");
                break;
            default:
                Console.WriteLine("Usted paga ${0}",autos*15);
                break;
        }
        EnterToContinue();
    }

    static void SameWithIf(){
        int autos = 5;

        if(autos==0){
            WritingLine("Usted no paga impuestos");
        } else if (autos == 1){
            WritingLine("Usted paga $15");
        } else if(autos==2){
            WritingLine("Usted paga $30");
        } else {
            Console.WriteLine("Usted paga ${0}",autos*15);
        }
        EnterToContinue();
    }

    static void PiedraPapelTijera() {
        string elejido = "Piedra";

        switch (elejido) {
            case "Piedra":
                WritingLine("Piedra mata tijera");
                break;
            case "Papel":
                WritingLine("Papel mata piedra");
                break;
            case "Tijera":
                WritingLine("Tijera mata papel");
                break;
            default:
                WritingLine("Ese elemento no forma parte del juego.");
                break;
        }
        EnterToContinue();
    }

    static void Puntaje(){
        string jugadorRecord = "Learsito";
        int puntajeRecord = 5000;
        WritingLine("Ingrese su nombre de usuario: ");
        string jugadorActual = ReadingLine();

        if (jugadorActual == jugadorRecord){
            WritingLine("Este jugador ya existe. Por favor, elija otro nombre. ");
            EnterToContinue();
        } else{
            WritingLine("Introduzca el puntaje obtenido: ");
            int puntajeObtenido = int.Parse(ReadingLine());
            if(puntajeObtenido > puntajeRecord){
                WritingLine("La nueva puntuación más alta es " + puntajeObtenido);
                WritingLine("La puntuación más alta fue lograda por " + jugadorActual);
            } else {
                WritingLine("La puntuación más alta de "+puntajeRecord+" no se ha podido superar, y aún está en manos de "+jugadorRecord);
            }
        }
    }
        
//WhatToDress();
//ParsingExample();
//AnidatedConditionals();
//EnterToContinue();
//ConditionalInOneLine();
//UserLogIn();
//SwitchStatement();
//SameWithIf();
//PiedraPapelTijera();
//Puntaje();

        //Declaración if mejorada - operador ternario
        /*
        //Condición ? primera expresión : segunda_expresión ;
        //la condición solo puede ser verdadera o falsa ( true / false )
        // el operador condicional es correcto, o sea que es asociativo
        //la expresión a ? b : c ? d : e
        //es evaluada como a ? b : (c ? d : e),
        //no como (a ? b : c) ? d : e

        */

    static void IfTernario(){
        int temperatura = -5;
        string estadoDelAgua;

        //if (temperatura < 0) estadoDelAgua = "sólido";
        //else estadoDelAgua = "líquido";                                 //Por código y estilo esto no se hace, se pone siempre con las llaves {}

        WritingLine("¿Cuál es la temperatura?");
        temperatura = int.Parse(ReadingLine());
        estadoDelAgua = temperatura <= 0 ? "sólido" : temperatura >0 && temperatura< 100 ? "líquido" : "gaseoso";

        WritingLine("El estado del agua es " + estadoDelAgua);
        EnterToContinue();
    }

    //IfTernario();
//Desafío
static void DesafioUno() {
    string temperaturaEntrada;
    string clima = "";
    int temperatura;
    WritingLine("Ingrese la temperatura actual: ");
    temperaturaEntrada = ReadingLine();

    if (int.TryParse(temperaturaEntrada, out temperatura)) {
        //temperatura = int.Parse(temperaturaEntrada);
        clima = temperatura <= 15 ? "Hace mucho frío"
        : temperatura >= 16 && temperatura <=28 ? "Hace clima agradable"
        : "Hace mucho calor";
        WritingLine(clima);
    } else {
        WritingLine("Esta no es una temperatura válida.");
    }
    
    EnterToContinue();
}

DesafioUno();