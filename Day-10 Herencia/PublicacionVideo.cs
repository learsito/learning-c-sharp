public class PublicacionVideo : Publicacion{
    //Variables
    protected bool seReproduce = false;
    protected int duracionActual = 0;

    Timer reloj;
    //Propiedades
    protected string UrlVideo { get; set; }
    protected int Duracion {get;set;}
    public PublicacionVideo(){}

    public PublicacionVideo(string titulo, string autor, string urlVideo, int duracion, bool isPublic){
        this.ID = CreateID();
        this.Titulo = titulo;
        this.Autor = autor;
        this.IsPublic = isPublic;

        this.UrlVideo = urlVideo;
        this.Duracion = duracion;
    }

    public override string ToString()
    {
        return string.Format(" {0} - {1} - {3} - {4}mins - Creado por {2}",this.ID,this.Titulo,this.Autor,this.UrlVideo,this.Duracion.ToString());
    }

    public void Play(){
        if(!seReproduce){
            seReproduce = true;
            System.Console.WriteLine("Reproduciendo");
            reloj = new Timer(Reproduccion,null,0,1000);
        }
    }

    public void Stop(){
        if(seReproduce){
            seReproduce = false;
            System.Console.WriteLine("\nDetenido en {0}s",duracionActual);
            duracionActual = 0;
            reloj.Dispose();
        }
    }

    private void Reproduccion(Object o){
        if(duracionActual<Duracion){
            duracionActual++;
            System.Console.WriteLine("Video en {0}s ",duracionActual);
            GC.Collect();
        }else{
            Stop();
        }
    }
}