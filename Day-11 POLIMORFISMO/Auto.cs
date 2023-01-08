public class Auto{
    protected int HP { get; set; }
    protected string Color { get; set; }

    //Tiene una relacion con AutoInfo
    protected AutoInfo autoInfo = new AutoInfo();

    public Auto(int hp, string color){
        this.HP = hp;
        this.Color = color;
    }

    public void ShowDetails(){
        Console.WriteLine("------------------------------------");
        Console.WriteLine("Este coche tiene {0} caballos de fuerza.", HP);
        Console.WriteLine("Este coche es de color {0}.",Color);
        Console.WriteLine("------------------------------------");
    }

    public virtual void Repair(){
        Console.WriteLine("------------------------------------");
        Console.WriteLine("Coche reparado.");
        Console.WriteLine("------------------------------------");
    }

    public void SttingAutoInfo(int id, string propietario){
        autoInfo.ID = id;
        autoInfo.Propietario = propietario;
    }

    public void LeerAutoInfo(){
        Console.WriteLine("El ID del auto es {0}, y su propietario es {1}",autoInfo.ID,autoInfo.Propietario);
    }
}