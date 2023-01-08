public class Publicacion{
    private static int publicacionID;

    //Propiedades
    protected int ID { get; set; } //Que puede verse solamente en esta clase y en las que deriven de ella
    protected string Titulo { get; set; }
    protected string Autor { get; set; }
    protected bool IsPublic { get; set; }

    //constructor por defecto
    public Publicacion(){
        ID = CreateID();
        Titulo = "Mi primera publicacion";
        IsPublic = true;
        Autor = "Juan Perez";
    }

    //Constructor parametrizado
    public Publicacion (string titulo, bool isPublic, string autor){
        this.ID = CreateID();
        this.Titulo = titulo;
        this.IsPublic = isPublic;
        this.Autor = autor;
    }

    //Método para crear ID
    protected int CreateID(){
        return ++publicacionID;
    }

    //Metodo para editar publicacion
    public void Edit(string titulo, bool isPublic){
        this.Titulo = titulo;
        this.IsPublic = isPublic;
    }

    public override string ToString()
    {
        return string.Format(" {0} - {1} - Creado por {2}",this.ID,this.Titulo,this.Autor);
    }
}