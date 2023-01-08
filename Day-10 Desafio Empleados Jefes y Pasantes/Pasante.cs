public class Pasante : Empleados{
    protected int HorasDeTrabajo {get;set;}
    protected int HorasDeEscuela {get;set;}

    public void Aprender(){
        System.Console.WriteLine("Estoy aprendiendo durante {0} horas",HorasDeEscuela);
    }

    public Pasante():base(){
        HorasDeTrabajo = 0;
        HorasDeEscuela = 0;
    }

    public Pasante(string nombre,string apellido, int salario, int horasTrabajo,int horasEscuela):base(nombre,apellido,salario){
        this.HorasDeTrabajo = horasTrabajo;
        this.HorasDeEscuela = horasEscuela;
    }

    public void Trabajar()
    {
        System.Console.WriteLine("Estoy trabajando {0} horas semanales",HorasDeTrabajo);
    }

}