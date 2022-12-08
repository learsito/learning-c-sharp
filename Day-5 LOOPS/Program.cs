static void EnterToContinue(string statement = ""){
        if(statement!=""){
            WritingLine(statement);
        }
        WritingLine("Presiona Enter para continuar...");
        Console.ReadKey();
    }

    static void WritingLine(dynamic statement ){
        Console.WriteLine(statement);
    }

    static string ReadingLine(){
        string statement = Console.ReadLine();
        return statement;
    }

//Loops
    //Lo básico
        /*
        *Ahorran tiempo
        *Repetición rápida y sencilla
        *Permite trabajar con cantidades enormes de información
        *Permite repetir Arrays
        */
            //Tipos
            /*
            *For - 
            *While - Verifica y luego ejecuta
            *Do while - Primero ejecuta y luego verifica
            *foreach -recorre una lista o Array
            */
                /*
                for(Valor inicial; condición;incremento){
                    código a ejecutar
                }
                while (condición){
                    //código a ejecutar
                    variableContadora++;
                }
                do {
                    //código a ejecutar
                    variableContadora++;
                }while(condición);
                */
                //foreach
                    /*
                    *Recorre un Array
                    *Lo hace en tanto haya contenido
                    *Veremos esto en la sección sobre Arrays
                    */

static void EjemploFor(){
    for(int contador = 0;contador<=50;contador+=5){
        WritingLine(contador);
    }
    EnterToContinue();
}

static void DesafioFor(){
    for(int i = 0;i<=20;i++){
        if(i%2 == 0) {
            continue;
        } else if (i%2!=0) {
            WritingLine(i);
        }
    }
    EnterToContinue();
}

static void EjemploDoWhile(){
    int contador = 15;
    do{
        WritingLine(contador);
        contador++;
    }while(contador<5);
    EnterToContinue();
}

static void ProgramaPruebaDoWhile(){
    int largoDeTexto = 0;
    string textoCompleto ="";

    do{
        WritingLine("Por favor, ingresa el nombre de un amigo");
        string nombreAmigo = ReadingLine();
        int largoActual = nombreAmigo.Length;
        largoDeTexto += largoActual;
        textoCompleto += nombreAmigo;
    } while(largoDeTexto < 20);
    WritingLine("Gracias, eso es todo. " + textoCompleto);
    EnterToContinue();
}

static void EjemploWhile(){
    int contador = 0;
    while(contador <10){
        WritingLine(contador);
        contador++;
    }
    EnterToContinue();
}

static void DesafioWhile(){
    string enter = "";
    int cantidad = 0;
    while(enter==""){
        WritingLine(cantidad);
        cantidad++;
        enter = ReadingLine();
    }
    EnterToContinue();
}

static void BreakExample(){
    for(int contador=0;contador<10;contador++){
        WritingLine(contador);
        if(contador==3){
            WritingLine("Al 3 nos detenemos");
            break;
        }
    }
    EnterToContinue();
}

static void ContinueExample(){
    for(int contador=0;contador<10;contador++){
        if(contador==3){
            WritingLine("Nos hemos saltado el 3");
            continue;
        }
        WritingLine(contador);
    }
    EnterToContinue();
}

static void OnlyOddWithContinue(){
    for(int contador=0;contador<10;contador++){
        if(contador%2 ==0){
            WritingLine("El próximo es impar");
            continue;
        }
        WritingLine(contador);
    }
    EnterToContinue();
}

//Desafíos

static void PromedioAlumno(){
    string valorIngresado = "";
    double calificacion = 0;
    double cantidad = 0;
    double valorDouble = 0;
    while(valorIngresado!="fin"){
        WritingLine("Ingrese la calificación o escriba fin: ");
        valorIngresado = ReadingLine();
        if(double.TryParse(valorIngresado, out valorDouble) && valorDouble >=1 && valorDouble <=10){
            calificacion+= double.Parse(valorIngresado);
            cantidad++;
        } else if (valorIngresado!="fin" && valorDouble <1 || valorDouble > 10){
            WritingLine("Debe ingresar un valor numérico entre 1 y 10. Por favor verifique su ingreso.");
        } else {
            break;
        }
    }
    double promedio =calificacion / cantidad;
    WritingLine("El promedio del alumno es: " + promedio);
    EnterToContinue();
}

PromedioAlumno();