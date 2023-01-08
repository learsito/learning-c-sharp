public class Empleados {
    protected string Nombre {get;set;}
    protected string Apellido {get;set;}
    protected int Salario {get;set;}

    public void Trabajar(){
        System.Console.WriteLine("Estoy trabajando");
    }

    public void Descansar(){
        System.Console.WriteLine("Estoy descansando");
    }

    public Empleados(){
        Nombre = "Nombre del empleado";
        Apellido = "Apellido del empleado";
        Salario = 0;
    }

    public Empleados(string nombre,string apellido, int salario){
        this.Nombre = nombre;
        this.Apellido = apellido;
        this.Salario =salario;
    }
}