//Arrays
/*
    Arrays o matrices:
    Almacenan una cantidad fija de elemetos
    SOLO elementos del mismo tipo entre sí
    Elementos de cualquier tipo: strings, int, bool, etc
    Ideal para almacenar una colección de datos

    //Estrcutura de un Array:
        El largo del siguiente array es 6:
        Valores: 12,15,5,7,8,1
        Índices:  0, 1,2,3,4,5
                                          //El elemento del
                                              índice 4 tiene un valor de 8

    //Para declarar un Array:
    tipoDeDato [] nombreDelArray;
    int [] calificaciones;
    //Inicialización de un Array
    tipoDeDato [] nombreDelArray = new tipoDeDato [cantidadDeEntradas];

    int [] calificaciones = new int [5];

    //Asignación de vlores en un Array:
    nombreDelArray [índice] = valor;

    calificaciones [0] = 7;
    calificaciones [1] = 9;

    //Llamada de un valor:
    nombreArray[4]; // Esto tendría un valor de 8 según el ejemplo de la estructura del Array.
*/

//Prácticas:
int [] calificaciones=new int[5];

calificaciones[0] = 10;
calificaciones[1] = 7;
calificaciones[2] = 9;
calificaciones[3] = 3;
calificaciones[4] = 7;

//string ingreso = Console.ReadLine();
//calificaciones[0] = int.Parse(ingreso);
System.Console.WriteLine("Primera calificación: {0} ", calificaciones[0]);

//Segunda manera de crar Arrays:
int[]edades = {17,15,16,15,17};

//Tercera manera de crear Arrays
int[]faltasAlColegio = new int[]{3,5,7,3,4,5};

System.Console.WriteLine("El array faltasAlColegio tiene {0} casos ",faltasAlColegio.Length);

//Loop foreach
/*
Se puede utilizar tanto para obtener todos los valores del array o para asignarle todos los valores
*/
int[]nums = new int[10];

for(int i=0; i<nums.Length;i++){
    nums[i] = i;
}

/*for(int j = 0;j< nums.Length;j++){
    System.Console.WriteLine("El valor del índice {0} es {1}",j,nums[j]);
}*/

foreach(int k in nums){
    Console.WriteLine("El valor del índice {0} es {1}",k,nums[k]);
}

//Desafío
/*Crear un Array con 5 nombres de amigos y crear un foreach para saludar a cada uno*/

string[]amigos={"Alberto","Edgar","Jude","Kevin","Analí"};

foreach(string h in amigos){
    Console.WriteLine("¡Hola, "+ h +"! ¿Cómo estás? ");
}
 int[]frutas={10,5,14,50};

 foreach(int cantidad in frutas){
    Console.WriteLine(cantidad);
 }

 //Arrays multi-dimensionales:
string[,] matriz2D;//Dos dimensiones
int[,,] matriz3D; //Array 3D

string [,] array2D =new string[,]{
    {"A","B","C"},
    {"D","E","F"},
    {"G","H","I"}
};

Console.WriteLine("El valor es {0} ",array2D[2,0]);

string [,,] array3D = new string[,,]{
    {
        {"A","B","C"},
        {"D","E","F"},
        {"G","H","I"}
    },
    {
        {"J","K","L"},
        {"M","N","Ñ"},
        {"O","P","Q"}
    },
    {
        {"R","S","T"},
        {"U","V","W"},
        {"X","Y","Z"}
    }
};

string [,] otroArray2D = new string[3,2]{ {"María","López"},{"Franco","Escamilla"},{"Juana","Garay"} };
System.Console.WriteLine(otroArray2D[1,1]);
otroArray2D[1,1] = "Miller";
System.Console.WriteLine(otroArray2D[1,1]);

//Console.WriteLine("El valor es {0} ",array3D[1,2,2]);
//Console.WriteLine("El valor es {0} ",array3D[2,1,1]);

int dimension = otroArray2D.Rank;

int[,]a2D ={{1,2},{3,4}};
System.Console.WriteLine(dimension);
