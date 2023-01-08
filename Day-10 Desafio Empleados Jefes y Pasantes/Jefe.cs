public class Jefe : Empleados{
    protected string AutoDeEmpresa {get;set;}

    public void Dirigir(){
        System.Console.WriteLine("Soy el jefazzo");
    }

    public Jefe():base(){
        AutoDeEmpresa = "Tesla";
    }

    public Jefe(string nombre,string apellido, int salario, string auto):base(nombre,apellido,salario){
        this.AutoDeEmpresa = auto;
    }


}