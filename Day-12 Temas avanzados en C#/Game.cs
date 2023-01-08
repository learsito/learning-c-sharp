namespace OneOfThree{
    public class GameOf{
        public static void ThreeAnswersGame(){
            Random answer = new Random();
            System.Console.WriteLine("Bienvenido. haga cualquier pregunta: ");
            while(true){
                int theAnswer = answer.Next(1,4);
                Console.ReadLine();
                switch (theAnswer){
                    case 1:
                        System.Console.WriteLine("Sí");
                        break;
                    case 2:
                        System.Console.WriteLine("No");
                        break;
                    case 3:
                        System.Console.WriteLine("Tal vez");
                        break;
                    default:
                        System.Console.WriteLine("Ha habido un error. valor de la variable theAnswer es: " + theAnswer);
                        break;
                }
            }
        }
    }

    public static class WorkingTime{
        public static DateTime ComingDay(){
            return DateTime.Today.AddDays(1);
        }

        public static DateTime FistDayOfYear( int year ){
            return new DateTime(year,1,1);
        }
    }
}

public struct Game {
    public string name;
    public string developer;

    public void Show(){
        System.Console.WriteLine("El nombre del juego es {0}",name);
        System.Console.WriteLine("El desarrollador es {0}",developer);
    }

    public Game(string name, string developer){ //Un struct no puede contener constructor por defecto: debe haber uno parametrizado
        this.name = name;
        this.developer = developer;
    }
}

enum Day { Monday,Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday };
enum Month { January = 1, February, March, April, May, June, July, August, September, October, November, December }
