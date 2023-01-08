public class PublicacionImagen : Publicacion{
    //Propiedad nueva
    protected string UrlImagen { get; set; }

    //Constructor por defecto
    public PublicacionImagen(){}

    //Constructor parametrizado
    public PublicacionImagen( string titulo, string autor, string urlImagen, bool isPublic ){
        this.ID = CreateID();
        this.Titulo = titulo;
        this.Autor = autor;
        this.IsPublic = isPublic;

        this.UrlImagen = urlImagen;
    }

    public override string ToString()
    {
        return string.Format(" {0} - {1} - {3} - Creado por {2}",this.ID,this.Titulo,this.Autor,this.UrlImagen);
    }

}