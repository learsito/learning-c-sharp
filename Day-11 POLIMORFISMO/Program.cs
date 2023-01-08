var autos = new List<Auto>{
    new Audi(200,"azul","A4"),
    new BMW(250,"rojo","M3")
};

foreach(var auto in autos){
    auto.Repair();
}

Auto auto1 = new BMW(200,"negro","Z3");
Auto auto2 = new Audi(100,"verde","A3");

auto1.ShowDetails();
auto2.ShowDetails();

auto1.SttingAutoInfo(1234,"Diego Villaseñor");
auto2.SttingAutoInfo(1235,"Lego Ilto");
auto1.LeerAutoInfo();
auto2.LeerAutoInfo();

BMW bmwm5 = new BMW(330,"blanco","M5");
bmwm5.ShowDetails();

Auto autob = (Auto)bmwm5;
autob.ShowDetails();

M3 miM3 = new M3(200,"rojo","M3 Super Turbo");
miM3.Repair();

//Escribir en archivos de texto
    //Manera 1
string[] lines = {"Primero: 253", "Segundo: 155", "Tercero: 147"};
File.WriteAllLines(@"C:\Users\Diego Villaseñor\Documents\C# curse\Day-11 POLIMORFISMO\Puntajes.txt",lines);
    //Manera 2
    /*
System.Console.WriteLine("Por favor ingrese el nombre del archivo");
string archivoNombre = Console.ReadLine();
System.Console.WriteLine("Por favor ingrese el contenido: ");
string text0 = Console.ReadLine();

File.WriteAllText(@"C:\Users\Diego Villaseñor\Documents\C# curse\Day-11 POLIMORFISMO\"+archivoNombre+".txt",text0);
*/

//Manera 3
using(StreamWriter archivo = new StreamWriter(@"C:\Users\Diego Villaseñor\Documents\C# curse\Day-11 POLIMORFISMO\miTexto.txt")){

    foreach(string line in lines){
        if(line.Contains("Segundo")){
            archivo.WriteLine(line);
        }
    }
}

//Para añadir texto a un archivo existente:
using(StreamWriter archivo = new StreamWriter(@"C:\Users\Diego Villaseñor\Documents\C# curse\Day-11 POLIMORFISMO\miTexto.txt",true)){
    archivo.WriteLine("Linea adicional");
}

//Leyendo archivos de texto: leyendo texto completo

/*string texto = System.IO.File.ReadAllText(@"C:\Users\Diego Villaseñor\Documents\C# curse\Day-11 POLIMORFISMO\LeerArchivoTexto.txt");
Console.WriteLine("El archivo contiene el siguiente texto: {0}",texto);

//Leer de a lineas
string[] lineas = System.IO.File.ReadAllLines(@"C:\Users\Diego Villaseñor\Documents\C# curse\Day-11 POLIMORFISMO\LeerArchivoTexto.txt");

foreach(string line in lineas){
    System.Console.WriteLine("\t" + line);
}*/
