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

    private string p1Name = "";

    private string p2Name = "";

    public void ShowTable(){
        Console.Clear();
        System.Console.WriteLine(" "+table[0,0]+"  |  "+table[0,1]+"  |  "+table[0,2]);
        System.Console.WriteLine("---------------");
        System.Console.WriteLine(" "+table[1,0]+"  |  "+table[1,1]+"  |  "+table[1,2]);
        System.Console.WriteLine("---------------");
        System.Console.WriteLine(" "+table[2,0]+"  |  "+table[2,1]+"  |  "+table[2,2]);
    }

    public void AskForPlayersNames(){
        System.Console.WriteLine("Elije un nombre para el jugador 1: ");
        p1Name = Console.ReadLine();
        System.Console.WriteLine("Elije un nombre para el jugador 2: ");
        p2Name = Console.ReadLine();
    }

    public void GetInputPlayer1(){
        bool needInput =true;
        Console.WriteLine("({0}) Seleccione una casilla: ",p1Name);
        while(needInput){
            user1Entry = Console.ReadLine();
            bool success = int.TryParse(user1Entry, out entry1ToInt);
            if (success){
                entry1ToInt = int.Parse(user1Entry);
                if(entry1ToInt < 1 || entry1ToInt > 9) {
                    Console.Clear();
                    ShowTable();
                    System.Console.WriteLine("({0})  El valor debe ser un número entre 1 y 9. Por favor introduzca un valor correcto: ",p1Name);
                } else{
                    entry1ToInt = int.Parse(user1Entry);
                    if (entry1ToInt == 1) {
                        if (table[0,0]!="1"){
                            Console.Clear();
                            ShowTable();
                            System.Console.WriteLine("({0}) Esta casilla ya está tomada. Por favor, seleccione una disponible: ",p1Name);
                        } else{
                            needInput =false;
                            continue;
                        }
                    }else if (entry1ToInt == 2) {
                        if (table[0,1]!="2"){
                            Console.Clear();
                            ShowTable();
                            System.Console.WriteLine("({0}) Esta casilla ya está tomada. Por favor, seleccione una disponible: ",p1Name);
                        } else{
                            needInput =false;
                            continue;
                        }
                    }else if (entry1ToInt == 3) {
                        if (table[0,2]!="3"){
                            Console.Clear();
                            ShowTable();
                            System.Console.WriteLine("({0}) Esta casilla ya está tomada. Por favor, seleccione una disponible: ",p1Name);
                        } else{
                            needInput =false;
                            continue;
                        }
                    }else if (entry1ToInt == 4) {
                        if (table[1,0]!="4"){
                            Console.Clear();
                            ShowTable();
                            System.Console.WriteLine("({0}) Esta casilla ya está tomada. Por favor, seleccione una disponible: ",p1Name);
                        } else{
                            needInput =false;
                            continue;
                        }
                    }else if (entry1ToInt == 5) {
                        if (table[1,1]!="5"){
                            Console.Clear();
                            ShowTable();
                            System.Console.WriteLine("({0}) Esta casilla ya está tomada. Por favor, seleccione una disponible: ",p1Name);
                        } else{
                            needInput =false;
                            continue;
                        }
                    }else if (entry1ToInt == 6) {
                        if (table[1,2]!="6"){
                            Console.Clear();
                            ShowTable();
                            System.Console.WriteLine("({0}) Esta casilla ya está tomada. Por favor, seleccione una disponible: ",p1Name);
                        } else{
                            needInput =false;
                            continue;
                        }
                    }else if (entry1ToInt == 7) {
                        if (table[2,0]!="7"){
                            Console.Clear();
                            ShowTable();
                            System.Console.WriteLine("({0}) Esta casilla ya está tomada. Por favor, seleccione una disponible: ",p1Name);
                        } else{
                            needInput =false;
                            continue;
                        }
                    }else if (entry1ToInt == 8) {
                        if (table[2,1]!="8"){
                            Console.Clear();
                            ShowTable();
                            System.Console.WriteLine("({0}) Esta casilla ya está tomada. Por favor, seleccione una disponible: ",p1Name);
                        } else{
                            needInput =false;
                            continue;
                        }
                    }else if (entry1ToInt == 9) {
                        if (table[2,2]!="9"){
                            Console.Clear();
                            ShowTable();
                            System.Console.WriteLine("({0}) Esta casilla ya está tomada. Por favor, seleccione una disponible: ",p1Name);
                        } else{
                            needInput = false;
                            continue;
                        }
                    }
                }
            }else{
                Console.Clear();
                ShowTable();
                System.Console.WriteLine("({0})  El valor debe ser un número entre 1 y 9. Por favor introduzca un valor correcto: ",p1Name);
            }
        }
    }

    public void GetInputPlayer2(){
        bool needInput =true;
        Console.WriteLine("({0}) Seleccione una casilla: ",p2Name);
        while(needInput){
            user2Entry = Console.ReadLine();
            bool success = int.TryParse(user2Entry, out entry2ToInt);
            if (success){
                entry2ToInt = int.Parse(user2Entry);
                if(entry2ToInt < 1 || entry2ToInt > 9) {
                    Console.Clear();
                    ShowTable();
                    System.Console.WriteLine("({0})  El valor debe ser un número entre 1 y 9. Por favor introduzca un valor correcto: ",p2Name);
                } else{
                    entry2ToInt = int.Parse(user2Entry);
                    if (entry2ToInt == 1) {
                        if (table[0,0]!="1"){
                            Console.Clear();
                            ShowTable();
                            System.Console.WriteLine("({0}) Esta casilla ya está tomada. Por favor, seleccione una disponible: ",p2Name);
                        } else{
                            needInput =false;
                            continue;
                        }
                    }else if (entry2ToInt == 2) {
                        if (table[0,1]!="2"){
                            Console.Clear();
                            ShowTable();
                            System.Console.WriteLine("({0}) Esta casilla ya está tomada. Por favor, seleccione una disponible: ",p2Name);
                        } else{
                            needInput =false;
                            continue;
                        }
                    }else if (entry2ToInt == 3) {
                        if (table[0,2]!="3"){
                            Console.Clear();
                            ShowTable();
                            System.Console.WriteLine("({0}) Esta casilla ya está tomada. Por favor, seleccione una disponible: ",p2Name);
                        } else{
                            needInput =false;
                            continue;
                        }
                    }else if (entry2ToInt == 4) {
                        if (table[1,0]!="4"){
                            Console.Clear();
                            ShowTable();
                            System.Console.WriteLine("({0}) Esta casilla ya está tomada. Por favor, seleccione una disponible: ",p2Name);
                        } else{
                            needInput =false;
                            continue;
                        }
                    }else if (entry2ToInt == 5) {
                        if (table[1,1]!="5"){
                            Console.Clear();
                            ShowTable();
                            System.Console.WriteLine("({0}) Esta casilla ya está tomada. Por favor, seleccione una disponible: ",p2Name);
                        } else{
                            needInput =false;
                            continue;
                        }
                    }else if (entry2ToInt == 6) {
                        if (table[1,2]!="6"){
                            Console.Clear();
                            ShowTable();
                            System.Console.WriteLine("({0}) Esta casilla ya está tomada. Por favor, seleccione una disponible: ",p2Name);
                        } else{
                            needInput =false;
                            continue;
                        }
                    }else if (entry2ToInt == 7) {
                        if (table[2,0]!="7"){
                            Console.Clear();
                            ShowTable();
                            System.Console.WriteLine("({0}) Esta casilla ya está tomada. Por favor, seleccione una disponible: ",p2Name);
                        } else{
                            needInput =false;
                            continue;
                        }
                    }else if (entry2ToInt == 8) {
                        if (table[2,1]!="8"){
                            Console.Clear();
                            ShowTable();
                            System.Console.WriteLine("({0}) Esta casilla ya está tomada. Por favor, seleccione una disponible: ",p2Name);
                        } else{
                            needInput =false;
                            continue;
                        }
                    }else if (entry2ToInt == 9) {
                        if (table[2,2]!="9"){
                            Console.Clear();
                            ShowTable();
                            System.Console.WriteLine("({0}) Esta casilla ya está tomada. Por favor, seleccione una disponible: ",p2Name);
                        } else{
                            needInput =false;
                            continue;
                        }
                    }
                }
            }else{
                Console.Clear();
                ShowTable();
                System.Console.WriteLine("({0})  El valor debe ser un número entre 1 y 9. Por favor introduzca un valor correcto: ",p2Name);
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
        Console.Clear();
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
            for(int i =0; i<table.GetLength(0);i++){
                for(int j = 0; j<table.GetLength(1);j++){
                    table[i,j] = ((i*3)+j+1).ToString();
                }
            }
        }
    }

    public string PlayerOneName(){
        return p1Name;
    }

    public string PlayerTwoName(){
        return p2Name;
    }

}