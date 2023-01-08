public class BMW:Auto{
    private string brand = "BMW";
    protected string Model { get; set; }

    public BMW(int hp, string color, string model):base(hp,color){
        this.Model = model;
    }

    public sealed override void Repair(){ //Sobreescribiendo //sellando con 'sealed', así no se podrá sobreescribir en las derivadas de esta clase. //Solo podemos sellar métodos sobreescritos, pues en la clase base se determina si se puede sobreescribir con la palabra clave 'virtual'.
        Console.WriteLine("------------------------------------");
        Console.WriteLine("{0} {1} reparado.",brand,Model);
        Console.WriteLine("------------------------------------");
    }

    public new void ShowDetails(){ //Dándole prioridad al metodo de la clase derivada.
        Console.WriteLine("------------------------------------");
        Console.WriteLine("Este coche es un {0}",brand);
        Console.WriteLine("El modelo es un {0}",Model);
        Console.WriteLine("Tiene {0} caballos de fuerza.",HP);
        Console.WriteLine("Es de color {0}",Color);
        Console.WriteLine("------------------------------------");
    }
}