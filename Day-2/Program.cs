Console.WriteLine("Hacer parsing de String a Integer");

string miString = "15";
string miSegundoString = "10";
string resultado = miString + miSegundoString;
    //The output would be equals to a string with the value: "1510".

int num1 = Int32.Parse(miString);
int num2 = Int32.Parse(miSegundoString);

int resultado0 = num1 + num2;

Console.WriteLine(resultado0);
//Console.Read();

    //Algunos métodos se String
    /* --SubString(int32) - Se utiliza para obtener una porción
    (substring) del string,comenzando desde un índice en particular.
    -- ToLower() - Para convertir todos los carácteres de un string en minúsculas.
    -- ToUpper() - Se utiliza para convertir  todos los carácteres de un string en 
    mayúsculas.
    -- Trim() - Se utiliza para eliminar todos los espacios en blanco iniciales
    y finales de un string.
    --IndexOf(string) - Se utiliza para obtener el índice de la primera aparición 
    de un carácter dentro de un string.
    --IsNullOrWhiteSpace() - Devuelve "true" tanto si el string es nulo
    o si está en blanco. De lo contrario devuelve "false".
    --String.Concat() - Para concatenar valores.
    --IndexOf() - Devuelve el index de la primera aparición del argumento dado.
        //String.Format():
        En C# el método String.Format() se utiliza para ionsertar el obnjeto o
        valor de la variable dentro de otro string.
        Con String.Format() podemos reemplazar el valor en el formato especificado.
        SINTAXIS: String.Format("Cualquier string {índice}",objeto);
        EJEMPLO: var nombre = "Federico";
        String.Format("Mi nombre es {0}",nombre);
    */
    //Ejercicio-1:
    string userName;
    string inputRequest = "Por favor, ingresa tu nombre y presiona Enter: ";
    Console.WriteLine(inputRequest);
    userName = Console.ReadLine();
    int userNameLength = userName.Length;
    Console.WriteLine(userName.ToUpper());
    Console.WriteLine(userName.ToLower());
    Console.WriteLine(userName.Trim());
    Console.WriteLine(userName.Substring(0,userNameLength));

    Console.WriteLine("Presione Enter para continuar...");
    Console.Read();

    //Ejercicio-2
        //Aplicación-1
            string texto;
            string subTexto;
            int indexSubTexto;
            Console.WriteLine("Ingrese un texto aqui: ");
            texto = Console.ReadLine();
            texto = Console.ReadLine();
            Console.WriteLine("Ingrese la letra o palabra buscada: ");
            subTexto = Console.ReadLine();
            indexSubTexto = texto.IndexOf(subTexto);
            Console.WriteLine("El índice de la primera aparición del carácter es: " + indexSubTexto);
            Console.WriteLine("Presione Enter para continuar...");
            Console.Read();
        //Aplicación-2
            string lastUserName;
            string fullName;
            Console.WriteLine("Por favor, ingrese su nombre: ");
            userName = Console.ReadLine();
            userName = Console.ReadLine();
            Console.WriteLine("Ahora su apellido: ");
            lastUserName = Console.ReadLine();
            fullName = userName.Trim() + " " + lastUserName.Trim();
            Console.WriteLine("Su nombre completo es: " + fullName); 
            Console.WriteLine("Presione Enter para continuar... ");
            Console.Read();
    //Ejercicio-3
        byte miByte = 25;
        Console.WriteLine(miByte);
        sbyte miSbyte = 15;
        Console.WriteLine(miSbyte);
        int miInt = 123456789;
        Console.WriteLine(miInt);
        uint miUint = 123091;
        Console.WriteLine(miUint);
        short miShort = 30567;
        Console.WriteLine(miShort);
        ushort miUshort = 30535;
        Console.WriteLine(miUshort);
        float miFloat = 3.33f;
        Console.WriteLine(miFloat);
        double miDouble = 3.14;
        Console.WriteLine(miDouble);
        char miChar = 'A';
        Console.WriteLine(miChar);
        bool miBool = true;
        Console.WriteLine(miBool);
        string miTexto = "Yo controlo el texto";
        Console.WriteLine(miTexto);
        string numTexto = "15";

        int miNumeroDesdeTexto = int.Parse(numTexto);
        Console.WriteLine(miNumeroDesdeTexto);
        Console.Read();
    
    //Constantes:
    const double pi = 3.1416;
    const int semanas = 52, meses = 12;
    const string nacimiento = "26.05.1998";

    Console.WriteLine("Mi nacimiento fue el: {0}",nacimiento);
    Console.Read();