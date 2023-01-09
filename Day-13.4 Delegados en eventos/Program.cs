//Eventos
    /*
        -Los eventos nos permiten comunicarnos entre objetos. Los objetos necesitan saber que hay
         otro objeto que está en cierto estado, por ejemplo. Y entonces pueden hacer algo y ahí es
         donde los eventos entran en juego.
        -Nos permiten crear un código más limpio, más mantenible, porque podemos crear
         aplicaciones levemente acopladas en las que podemos escribir el código para que las clases
         no sean inherentemente independientes unas de otras, y podemos extender fácilmente nuestro
         código sin romper nada.
        -Permiten que el receptor escuche al emisor y ejecute cosas una vez que algo ya ha
         sucedido.

        Es por esto que es muy útil, porque hay muchas situcaciones en las que tenemos,
        por ejemplo, que un usuario presiona un botón (que básicamente un botón es iniciar un
        evento), y entonces una vez que lo hace, ¿qué haremos cuando cuando eso haya sucedido?
        Puede ser:
            -Cambiar la interfaz de usuario
            -Obtener una base de datos
            -Entre otras cosas...

        Ejemplo:
            public class AsistenteDescarga{
                public void Descargar(Archivo archivo){
                    //Lógica de descarga 
                    ServicioDesempacar.Desempacar();
                    //Añadiendo otro método en el futuro:
                    ServicioNotificacion.Enviar(new Notificacion());
                }
            }
    */
//Delegados
    /*
        -El delegado es un contrato entre el emisor y el receptos.
        -El delegado determina la firma de un método gestor de eventos en el receptor y puede
         contener muchos punteros de métodos.
    */

MyMain();

static void MyMain(){
    var archivo = new Archivo(){Titulo="Archivo 1"};
    var asistenteDescarga = new AsistenteDescarga(); //emisor
    var servicioDesempacar = new ServicioDesempacar();//receptor
    var ServicioNotificacion = new ServicioNotificacion();//receptor

    asistenteDescarga.ArchivoDescargado += servicioDesempacar.EnArchivoDescargado;
    asistenteDescarga.ArchivoDescargado += ServicioNotificacion.EnArchivoDescargado;
    asistenteDescarga.Descarga(archivo);
}