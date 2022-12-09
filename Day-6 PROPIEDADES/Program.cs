Caja miCaja = new Caja(5,4,10);
/*caja1.SetLargo(5);
caja1.alto=3;
caja1.ancho=4;*/

//caja1.Largo = 5;
//Console.WriteLine(caja1.Largo);
//miCaja.Ancho =3;
//miCaja.Volumen=5; //La he seteado porque se puede pero no podría acceder a ella o hacer el get
//miCaja.Alto=-4;
//miCaja.SuperficieFrontal = 4; //No se puede porque la propiedad solo permite leer
Console.WriteLine("La superficie frontal de la caja es {0}", miCaja.SuperficieFrontal);
miCaja.MuestraInfo();
Console.ReadKey();

//Esto que hemos visto es el ENCAPSULAMIENTO
    /*
    Encapsular es el proceso de encerrar uno o más elementos en un paquete físico o lógico.
    En POO esto previene acceso a detalles de implementación. 
    */