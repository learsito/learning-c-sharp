public class ServicioNotificacion{
    public void EnArchivoDescargado(object fuente,ArchivoEventArgs e){
        System.Console.WriteLine("Archivo {0} descargado exitosamente.",e.Archivo.Titulo);
    }
}