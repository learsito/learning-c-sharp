//HERENCIA
    /*
    la herencia mos permite definir una clase en función de otra clase.
    Esto hace que sea más fácil crear y mantener una aplicación.
    Esto también la oportunidad de reutilizar la funcionalidad del código
    y acelerar el tiempo de implementación.
    */
    Publicacion post1 = new Publicacion("Gracias por los saludos de cumpleaños",true,"Diego Villaseñor");
    System.Console.WriteLine(post1.ToString());

    PublicacionImagen imagen1 = new PublicacionImagen("Mira mi perrito","Diego Ivish","https://imagen.com/perrito",true);
    System.Console.WriteLine(imagen1.ToString());

    //Desafio: generar una nueva clase llamada PublicacionVideo derivada de publicacion y crear propiedades nuevas tales como:
    /*
        -UrlVideo
        -Duracion
        //Crear los constructore: el por defecto y el parametrizado.
        //Ajustar el metodo ToString()
        //Crear una instancia de PublicacionVideo
    */

    PublicacionVideo videoUno = new PublicacionVideo("Checa este tiktok JAJAJA","Lola Mento","https://www.YouTube.com/view-QrfGTHyh67",15,true);
    System.Console.WriteLine(videoUno.ToString());
    videoUno.Play();
    System.Console.WriteLine("Presiona cualquier tecla para detener");
    Console.ReadKey();
    videoUno.Stop();