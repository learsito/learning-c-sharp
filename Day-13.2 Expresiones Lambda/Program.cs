//Exresiones Lambda 
    /*
        -Una expresión lambda es una función anónima que se puede usar para crear delegados o tipos de árbol de expresión.
        -Al usar expresiones lambda, puedes escribir funciones locales que pueden pasarse como argumentos
         o devolverse como el vlor de las llamadas a funciones.
        -Son particularmente útiles para escribir expresiones de consulta LINQ.

    */

Programa.MyMain();

public class Programa{
    public delegate int Calculos (int i);
    public delegate bool Comparacion(int i, Numero n);

    public static void MyMain(){
        HacerAlgo();
    }

    public static void HacerAlgo(){
        Calculos mate = new Calculos(PorDiez);

        System.Console.WriteLine(mate(8));

        List<int> lista = new List<int>{ 1,2,3,4,5,6,7 };
        List<int> numerosPares = lista.FindAll(delegate(int i){
            return (i%2==0);
        });

        /*List<int> numerosInpares = lista.FindAll(delegate(int i){
            return (i%2!=0);
        });*/

        foreach(int par in numerosPares){
            System.Console.WriteLine(par);
        }

        System.Console.WriteLine("----------------");

        List<int> numerosImpares = lista.FindAll(i=> i%2==1);
            numerosImpares.ForEach(i=> {
                Console.WriteLine("Numero impar: ");
                Console.WriteLine(i);
            }
        );

        mate = new Calculos(x=> x*x*x);
        System.Console.WriteLine(mate(8));

        Comparacion comp = (a,Numero) => a == Numero.n;

        System.Console.WriteLine(comp(5,new Numero {n=5}));

        /*foreach(int inpar in numerosInpares){
            System.Console.WriteLine(inpar);
        }*/

    }

    static int Sumar(int a, int b){
        return a+b;
    }

    static int Cuadrado(int i){
        return i*i;
    }

    static int PorDiez(int i){
        return i*10;
    }
}

    public class Numero{
        public int n { get; set; }
    }