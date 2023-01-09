public class ArchivoEventArgs : EventArgs{
    public Archivo Archivo { get; set; }
}

public class AsistenteDescarga{
    //Paso 1: crear el delegado
    //public delegate void GestorEventoArchivoDescargado(object fuente, ArchivoEventArgs args);

    //Paso 2: Crear el evento basado en el delegdo 
    public event EventHandler<ArchivoEventArgs> ArchivoDescargado;
    //Paso 3: preparar el inicio del evento
    protected virtual void EnArchivoDescargado(Archivo archivo){
        if(ArchivoDescargado!=null){
            ArchivoDescargado(this,new ArchivoEventArgs(){Archivo = archivo});
        }
    }
    public void Descarga(Archivo archivo){
        Console.WriteLine("Descargando archivo...");
        Thread.Sleep(4000);

        //Paso 3.1
        EnArchivoDescargado(archivo);
    }
}