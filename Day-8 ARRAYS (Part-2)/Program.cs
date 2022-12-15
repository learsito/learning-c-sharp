using System.Collections;
//Arrays irregulares
int [][] irregular = new int[3][];

irregular[0] = new int[5];
irregular[1] = new int[3];
irregular[2] = new int[2];

irregular[0] = new int[] {2,3,8,9,11};
irregular[1] = new int[] {23,100,15};
irregular[2] = new int[] {6,900};

int [][] irregular2 = new int [][]{
    new int[] {2,3,8,9,11},
    new int[] {23,100,15},
    new int[] {5,900}
};

//System.Console.WriteLine("El valor en el medio del primer array es {0}",irregular2[0][2]);

void DesafioUno(){
    for(int i = 0; i < irregular2.Length; i++){
        Console.WriteLine("Los valores del array {0} son:",i);
        for(int j = 0; j < irregular2[i].Length; j++){
            Console.WriteLine(irregular2[i][j]);
        }
    }
}

void DesafioDos(){
    string [][] families = new string [][]{
        new string[] {"Analí","Daniela"},
        new string[] {"Edgar","Jude","Paco","Sofía"},
        new string[] {"Christian", "Rubí","Zandra"}
    };
    for(int i = 0; i < families[1].Length; i++){
        System.Console.WriteLine("Hola, {0}. Soy {1}.",families[1][i],families[0][0]);
    }
    for(int j = 0; j < families[0].Length; j++){
        System.Console.WriteLine("Hola, {0}. Soy {1}.",families[0][j],families[1][0]);
    }
}

//Usando Arrays como Parámetros

int [] calificaciones = new int [] {8,7,9,3,10,5,4,7};
double promedioResultado = ObtainAverage(calificaciones);

/*foreach(int nota in calificaciones){
    System.Console.WriteLine("La nota es: {0}",nota);
}*/

//System.Console.WriteLine("Por lo tanto, el promedio es de: ",promedioResultado);

static double ObtainAverage(int [] arrayDePuntajes){
    int cantidad = arrayDePuntajes.Length;
    double promedio;
    int suma = 0;

    for(int i = 0; i<cantidad;i++){
        suma += arrayDePuntajes[i];
    }

    promedio = (double) suma / cantidad;

    return promedio;
}


/*Soy el dueño de un banco. Mi array contendrá todos los saldos de las cuentas
de mis clientes. Tengo 4 clientes. Les daré un crédito de $200 a cada uno.*/

static int [] ApplyCredit(int credit, int [] cuentas){
    for(int i = 0; i < cuentas.Length; i++){
        cuentas[i] += credit;
    }
    return cuentas;
}

int [] accounts = new int [] {800,300,1800,2800};

ApplyCredit(200,accounts);

foreach(int saldo2 in accounts){
    System.Console.WriteLine(saldo2);
}

//ArrayLists
/*
Es un tipo de Array distinto que permite contener diferentes tipos de objetos
(int,double,string)
*/

ArrayList miArrayList = new ArrayList(); //ArrayList indeterminado
ArrayList miArrayListDos = new ArrayList(100); //ArrayList determinado

//Agregar elementos al ArrayList
miArrayList.Add(25);
miArrayList.Add("Hola");
miArrayList.Add(13.37);
miArrayList.Add(13);
miArrayList.Add(128);
miArrayList.Add(true);

//Eliminar elementos

miArrayList.Remove(13); //Si este contuviera más de un 13 se eliminaría solo el primero
                        //si no existe ningún 13 no dará error, simplemente no eliminará nada

//Eliminar por posición (o índice)
miArrayList.RemoveAt(0);

//Contar elementos del arraylist
System.Console.WriteLine(miArrayList.Count);

double suma =0;

foreach(object obj in miArrayList){
    if(obj is int){
        suma += Convert.ToDouble(obj);
    } else if (obj is double){
        suma += (double)obj;
    }else if(obj is string){
        System.Console.WriteLine(obj);
    }

}
System.Console.WriteLine(suma);
//Colecciones: listas = Una manera flexible de trabajar con grupos de objetos/valores
/*
Son un tipo de colección.
A diferencia de los arrays, el tamaño de este grupo de objetos/valores
puede aumentar o disminuir dinámicamente.

Una colección es una clase, y requiere una instancia de la clase antes de
comenzar a agregar elementos en esa colección.

Para colecciones que solo contienen un tipo de datos, usamos el namespace:
'System.Collections.Generic'

*/
//Ejemplo:
    //Tipo int Sin valores
        var numeros = new List<int>();
    //Tipo int con valores
        var numeros2 = new List <int>{1,5,35,100};
    //Agregar y eliminar valores:
        var ejemplo = new List<int>();
        //Agregar un integer de valor 7 a la lista:
        ejemplo.Add(7);
        //Eliminar un elemento con el valor 7 de la lista:
        ejemplo.Remove(7);
        //Remover un elemento de una posición especificada (índice):
        int indice = 0;
        //numeros.RemoveAt(indice);
    //Obtener un valor:
        var valor = new List<int>();
        //Agrega un integer de valor 25 a la lista:
        valor.Add(25);
        //Asigna a una varible el valor del índice 0 de la lista (25):
        int value = valor[0];
    //Limpiar o vaciar una lista
        var numeros0 = new List<int>();
        numeros0.Add(25);
        numeros0.Add(50);
        //Elimina todos los elementos de la lista
        numeros0.Clear();
    //Listas y loops, ejemplo:
        var nums = new List<int>{5,10,15,20,25,30,35,40};
        //Loop foreach: 
        foreach(int elemento in nums){
            System.Console.WriteLine(elemento);
        }
        //loop for
        for (int i = 0; i < nums.Count; i++){
            System.Console.WriteLine(nums[i]);
        }

//ArrayLists vs Arrays vs Listas
    //Arrays:
    int[] puntajes = new int[]{99,96,87,76}; // Inmutable, limitado a 1 tipo
    //Listas:
    List<int> lista = new List<int>{1,2,3,4};
    lista.Add(0);
    lista.Add(32);
    lista.Sort(); //Ordenar una lista, por defecto de menor a mayor
    lista.RemoveRange(2,2); //Permite eliminar una serie de datos.


    foreach(int i in lista){
        System.Console.WriteLine(i); //Foreach en listas y en arrays porque ambos son colecciones
    }

    System.Console.WriteLine(lista.Contains(4));
    System.Console.WriteLine(puntajes.Contains(76));

    int indice0 = lista.FindIndex(x=> x==4);
    System.Console.WriteLine(lista[indice0]); 

    lista.RemoveAt(indice0);

    lista.ForEach(i => System.Console.WriteLine(i));

    System.Collections.ArrayList arrl = new System.Collections.ArrayList(); //Se debe invocar el namespace using 'System.Collections;'

    arrl.Add(1);
    arrl.Add("dos");
    arrl.Add(3);
    arrl.Add(new numero {n=4});

    foreach(object o in arrl){
        System.Console.WriteLine(o);
    }

    class numero {
        public int n {get;set;}

        public override string ToString(){
            return n.ToString();
        }
    }