public class Audi : Auto{
    private string brand = "Audi";
    protected string Model { get; set; }

    public Audi(int hp, string color, string model):base(hp,color){
        this.Model = model;
    }

    public override void Repair(){
        Console.WriteLine("------------------------------------");
        Console.WriteLine("{0} {1} reparado.",brand,Model);
        Console.WriteLine("------------------------------------");
    }

    public void ShowDetails(){
        Console.WriteLine("------------------------------------");
        Console.WriteLine("Este coche es un {0}",brand);
        Console.WriteLine("El modelo es un {0}",Model);
        Console.WriteLine("Tiene {0} caballos de fuerza.",HP);
        Console.WriteLine("Es de color {0}",Color);
        Console.WriteLine("------------------------------------");
    }
}