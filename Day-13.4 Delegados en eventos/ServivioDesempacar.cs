public class ServicioDesempacar{
    public void EnArchivoDescargado(object fuente, ArchivoEventArgs e){
        System.Console.WriteLine("ServicioDesempacar: desempacando el archivo "+e.Archivo.Titulo);
    }
}