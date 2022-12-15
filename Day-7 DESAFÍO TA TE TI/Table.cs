public class Table {
        private string [,] table = {
        {"1","2","3"},
        {"4","5","6"},
        {"7","8","9"}
    };

    private string user1Entry = "";
    private string user2Entry = "";
    private int entry1ToInt=0;
    private int entry2ToInt=0;

    public void ShowTable(){
        Console.Clear();
        System.Console.WriteLine(" "+table[0,0]+"  |  "+table[0,1]+"  |  "+table[0,2]);
        System.Console.WriteLine("---------------");
        System.Console.WriteLine(" "+table[1,0]+"  |  "+table[1,1]+"  |  "+table[1,2]);
        System.Console.WriteLine("---------------");
        System.Console.WriteLine(" "+table[2,0]+"  |  "+table[2,1]+"  |  "+table[2,2]);
    }

    public void GetInputPlayer1(){
        bool needInput =true;
        Console.WriteLine("(Jugador 1) Seleccione una casilla: ");
        while(needInput){
            user1Entry = Console.ReadLine();
            bool success = int.TryParse(user1Entry, out entry1ToInt);
            if (success){
                entry1ToInt = int.Parse(user1Entry);
                if(entry1ToInt < 1 || entry1ToInt > 9) {
                    System.Console.WriteLine("El valor debe ser un número entre 1 y 9. Por favor introduzca un valor correcto: ");
                } else{
                    entry1ToInt = int.Parse(user1Entry);
                    if (entry1ToInt == 1) {
                        if (table[0,0]!="1"){
                            System.Console.WriteLine("Esta casilla ya está tomada. Por favor, seleccione una disponible: ");
                        } else{
                            needInput =false;
                            continue;
                        }
                    }else if (entry1ToInt == 2) {
                        if (table[0,1]!="2"){
                            System.Console.WriteLine("Esta casilla ya está tomada. Por favor, seleccione una disponible: ");
                        } else{
                            needInput =false;
                            continue;
                        }
                    }else if (entry1ToInt == 3) {
                        if (table[0,2]!="3"){
                            System.Console.WriteLine("Esta casilla ya está tomada. Por favor, seleccione una disponible: ");
                        } else{
                            needInput =false;
                            continue;
                        }
                    }else if (entry1ToInt == 4) {
                        if (table[1,0]!="4"){
                            System.Console.WriteLine("Esta casilla ya está tomada. Por favor, seleccione una disponible: ");
                        } else{
                            needInput =false;
                            continue;
                        }
                    }else if (entry1ToInt == 5) {
                        if (table[1,1]!="5"){
                            System.Console.WriteLine("Esta casilla ya está tomada. Por favor, seleccione una disponible: ");
                        } else{
                            needInput =false;
                            continue;
                        }
                    }else if (entry1ToInt == 6) {
                        if (table[1,2]!="6"){
                            System.Console.WriteLine("Esta casilla ya está tomada. Por favor, seleccione una disponible: ");
                        } else{
                            needInput =false;
                            continue;
                        }
                    }else if (entry1ToInt == 7) {
                        if (table[2,0]!="7"){
                            System.Console.WriteLine("Esta casilla ya está tomada. Por favor, seleccione una disponible: ");
                        } else{
                            needInput =false;
                            continue;
                        }
                    }else if (entry1ToInt == 8) {
                        if (table[2,1]!="8"){
                            System.Console.WriteLine("Esta casilla ya está tomada. Por favor, seleccione una disponible: ");
                        } else{
                            needInput =false;
                            continue;
                        }
                    }else if (entry1ToInt == 9) {
                        if (table[2,2]!="9"){
                            System.Console.WriteLine("Esta casilla ya está tomada. Por favor, seleccione una disponible: ");
                        } else{
                            needInput =false;
                            continue;
                        }
                    }
                }
            }else{
                Console.WriteLine("El valor debe ser un número entre 1 y 9. Por favor introduzca un valor correcto: ");
            }
        }
    }

    public void GetInputPlayer2(){
        bool needInput =true;
        Console.WriteLine("(Jugador 2) Seleccione una casilla: ");
        while(needInput){
            user2Entry = Console.ReadLine();
            bool success = int.TryParse(user2Entry, out entry2ToInt);
            if (success){
                entry2ToInt = int.Parse(user2Entry);
                if(entry2ToInt < 1 || entry2ToInt > 9) {
                    Console.WriteLine("El valor debe ser un número entre 1 y 9. Por favor introduzca un valor correcto: ");
                } else{
                    entry2ToInt = int.Parse(user2Entry);
                    if (entry2ToInt == 1) {
                        if (table[0,0]!="1"){
                            System.Console.WriteLine("Esta casilla ya está tomada. Por favor, seleccione una disponible: ");
                        } else{
                            needInput =false;
                            continue;
                        }
                    }else if (entry2ToInt == 2) {
                        if (table[0,1]!="2"){
                            System.Console.WriteLine("Esta casilla ya está tomada. Por favor, seleccione una disponible: ");
                        } else{
                            needInput =false;
                            continue;
                        }
                    }else if (entry2ToInt == 3) {
                        if (table[0,2]!="3"){
                            System.Console.WriteLine("Esta casilla ya está tomada. Por favor, seleccione una disponible: ");
                        } else{
                            needInput =false;
                            continue;
                        }
                    }else if (entry2ToInt == 4) {
                        if (table[1,0]!="4"){
                            System.Console.WriteLine("Esta casilla ya está tomada. Por favor, seleccione una disponible: ");
                        } else{
                            needInput =false;
                            continue;
                        }
                    }else if (entry2ToInt == 5) {
                        if (table[1,1]!="5"){
                            System.Console.WriteLine("Esta casilla ya está tomada. Por favor, seleccione una disponible: ");
                        } else{
                            needInput =false;
                            continue;
                        }
                    }else if (entry2ToInt == 6) {
                        if (table[1,2]!="6"){
                            System.Console.WriteLine("Esta casilla ya está tomada. Por favor, seleccione una disponible: ");
                        } else{
                            needInput =false;
                            continue;
                        }
                    }else if (entry2ToInt == 7) {
                        if (table[2,0]!="7"){
                            System.Console.WriteLine("Esta casilla ya está tomada. Por favor, seleccione una disponible: ");
                        } else{
                            needInput =false;
                            continue;
                        }
                    }else if (entry2ToInt == 8) {
                        if (table[2,1]!="8"){
                            System.Console.WriteLine("Esta casilla ya está tomada. Por favor, seleccione una disponible: ");
                        } else{
                            needInput =false;
                            continue;
                        }
                    }else if (entry2ToInt == 9) {
                        if (table[2,2]!="9"){
                            System.Console.WriteLine("Esta casilla ya está tomada. Por favor, seleccione una disponible: ");
                        } else{
                            needInput =false;
                            continue;
                        }
                    }
                }
            }else{
                Console.WriteLine("El valor debe ser un número entre 1 y 9. Por favor introduzca un valor correcto: ");
            }
        }
    }

    public void TableTransformPlayer1(){
        entry1ToInt = int.Parse(user1Entry);
         if (entry1ToInt == 1 && table[0,0] == "1"){
            table[0,0] = "O";
        } else if (entry1ToInt ==2 && table[0,1] == "2"){
            table[0,1] = "O";
        } else if (entry1ToInt==3 && table[0,2] == "3") {
            table[0,2] = "O";
        }else if (entry1ToInt==4 && table[1,0] == "4") {
            table[1,0] = "O";
        }else if (entry1ToInt==5 && table[1,1] == "5"){
            table[1,1] = "O";
        }else if (entry1ToInt==6 && table[1,2] == "6"){
            table[1,2] = "O";
        }else if (entry1ToInt==7 && table[2,0] == "7"){
            table[2,0] = "O";
        }else if (entry1ToInt==8 && table[2,1] == "8"){
            table[2,1] = "O";
        }else if (entry1ToInt==9 && table[2,2] == "9"){
            table[2,2] = "O";
        }
    }

    public void TableTransformPlayer2(){
        entry2ToInt = int.Parse(user2Entry);
         if (entry2ToInt == 1&& table[0,0] == "1"){
            table[0,0] = "X";
        } else if (entry2ToInt ==2&& table[0,1] == "2"){
            table[0,1] = "X";
        } else if (entry2ToInt==3&& table[0,2] == "3") {
            table[0,2] = "X";
        }else if (entry2ToInt==4&& table[1,0] == "4") {
            table[1,0] = "X";
        }else if (entry2ToInt==5&& table[1,1] == "5"){
            table[1,1] = "X";
        }else if (entry2ToInt==6&& table[1,2] == "6"){
            table[1,2] = "X";
        }else if (entry2ToInt==7&& table[2,0] == "7"){
            table[2,0] = "X";
        }else if (entry2ToInt==8&& table[2,1] == "8"){
            table[2,1] = "X";
        }else if (entry2ToInt==9&& table[2,2] == "9"){
            table[2,2] = "X";
        }

    }

    public bool WinnerVerify(){
        bool winner = false;
        if (table[0,0]== "X" && table[0,1]== "X" && table[0,2] == "X" || table[0,0]=="O" && table[0,1]=="O" && table[0,2] =="O"){
            winner = true;
        } else if ((table[1,0]== "X" && table[1,1]== "X" && table[1,2] == "X") || (table[1,0]=="O" && table[1,1]=="O" && table[1,2] =="O")){
            winner = true;
        } else if ((table[2,0]== "X" && table[2,1]== "X" && table[2,2] == "X") || (table[2,0]=="O" && table[2,1]=="O" && table[2,2] =="O")){
            winner = true;
        }else if ((table[0,0]== "X" && table[1,0]== "X" && table[2,0] == "X") || (table[0,0]=="O" && table[1,0]=="O" && table[2,0] =="O")){
            winner = true;
        }else if ((table[0,1]== "X" && table[1,1]== "X" && table[2,1] == "X" )|| (table[0,1]=="O" && table[1,1]=="O" && table[2,1] =="O")){
            winner = true;
        }else if ((table[0,2]== "X" && table[1,2]== "X" && table[2,2] == "X") || (table[0,2]=="O" && table[1,2] =="O"&& table[2,2] =="O")){
            winner = true;
        }else if ((table[2,0]== "X" && table[1,1]== "X" && table[0,2] == "X" )||( table[2,0]=="O" && table[1,1]=="O" && table[0,2] =="O")){
            winner = true;
        }else if ((table[0,0]== "X" && table[1,1]== "X" && table[2,2] == "X") || (table[0,0]=="O" && table[1,1]=="O" && table[2,2] =="O")){
            winner = true;
        }
        return winner;
    }

    public bool EveryBoxFilled(){
        bool filled=false;
        if ((table[0,0] == "X" || table[0,0] == "O") &&(table[0,1] == "X" || table[0,1] == "O") &&(table[0,2] == "X" || table[0,2] == "O") &&(table[1,0] == "X" || table[1,0] == "O") &&(table[1,1] == "X" || table[1,1] == "O") &&(table[1,2] == "X" || table[1,2] == "O") &&(table[2,0] == "X" || table[2,0] == "O") &&(table[2,1] == "X" || table[2,1] == "O") &&(table[2,2] == "X" || table[2,2] == "O")  ){
            filled = true;
        }
        return filled;
    }

    public void Welcome(){
        System.Console.WriteLine("Bienvenido al juego de El Gato. Presione Enter para comenzar...");
        Console.ReadKey();
    }

    public bool PlayerOneWins(){
        bool oneWins;
        if (table[0,0]=="O" && table[0,1]=="O" && table[0,2] =="O"){
            oneWins = true;
        } else if (table[1,0]=="O" && table[1,1]=="O" && table[1,2] =="O"){
            oneWins = true;
        } else if (table[2,0]=="O" && table[2,1]=="O" && table[2,2] =="O"){
            oneWins = true;
        }else if (table[0,0]=="O" && table[1,0]=="O" && table[2,0] =="O"){
            oneWins = true;
        }else if (table[0,1]=="O" && table[1,1] =="O"&& table[2,1] =="O"){
            oneWins = true;
        }else if (table[0,2] =="O"&& table[1,2]=="O" && table[2,2] =="O"){
            oneWins = true;
        }else if (table[2,0] =="O"&& table[1,1]=="O" && table[0,2] =="O"){
            oneWins = true;
        }else if (table[0,0]=="O" && table[1,1]=="O" && table[2,2] =="O"){
            oneWins = true;
        } else{
            oneWins=false;
        }
        return oneWins;
    }

    public bool PlayerTwoWins(){
        bool twoWins;
        if (table[0,0]=="X" && table[0,1] =="X"&& table[0,2] =="X"){
            twoWins = true;
        } else if (table[1,0]=="X" && table[1,1] =="X"&& table[1,2] =="X"){
            twoWins = true;
        } else if (table[2,0] =="X"&& table[2,1]=="X" && table[2,2] =="X"){
            twoWins = true;
        }else if (table[0,0]=="X" && table[1,0] =="X"&& table[2,0] =="X"){
            twoWins = true;
        }else if (table[0,1] =="X"&& table[1,1]=="X" && table[2,1] =="X"){
            twoWins = true;
        }else if (table[0,2]=="X" && table[1,2]=="X" && table[2,2] =="X"){
            twoWins = true;
        }else if (table[2,0] =="X"&& table[1,1]=="X" && table[0,2] =="X"){
            twoWins = true;
        }else if (table[0,0]=="X" && table[1,1]=="X" && table[2,2] =="X"){
            twoWins = true;
        } else{
            twoWins=false;
        }
        return twoWins;
    }

    public void Reset(){
        if (WinnerVerify()==true || EveryBoxFilled()==true){
            table[0,0] = "1";
            table[0,1] = "2";
            table[0,2] = "3";
            table[1,0] = "4";
            table[1,1] = "5";
            table[1,2] = "6";
            table[2,0] = "7";
            table[2,1] = "8";
            table[2,2] = "9";
        }
    }

}