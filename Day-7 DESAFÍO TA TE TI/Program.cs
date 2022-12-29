Table mainTable = new Table();
bool gameOn = true;

mainTable.Welcome();
mainTable.AskForPlayersNames();

do{
    while(mainTable.WinnerVerify()==false && mainTable.EveryBoxFilled()==false){
        mainTable.ShowTable();
        if(mainTable.WinnerVerify()==true || mainTable.EveryBoxFilled()==true){
            continue;
        }
        mainTable.GetInputPlayer1();
        mainTable.TableTransformPlayer1();
        mainTable.ShowTable();
        if(mainTable.WinnerVerify()==true || mainTable.EveryBoxFilled()==true){
            continue;
        }
        mainTable.GetInputPlayer2();
        mainTable.TableTransformPlayer2();
    }

    if(mainTable.WinnerVerify() && mainTable.PlayerOneWins()) {
            Console.WriteLine("¡Felicidades!");
            Console.WriteLine("Ha ganado {0}.",mainTable.PlayerOneName());
            Console.WriteLine("Presione cualquier tecla para reiniciar el juego...");
            mainTable.Reset();
            Console.ReadKey();
        } else if(mainTable.WinnerVerify() && mainTable.PlayerTwoWins()){
            Console.WriteLine("¡Felicidades!");
            Console.WriteLine("Ha ganado {0}.",mainTable.PlayerTwoName());
            Console.WriteLine("Presione cualquier tecla para reiniciar el juego...");
            mainTable.Reset();
            Console.ReadKey();
        }else if (mainTable.EveryBoxFilled()){
        Console.WriteLine("Gato encerrado. Presione cualquier tecla para reiniciar el juego...");
        mainTable.Reset();
        Console.ReadKey();
    }else{
        System.Console.WriteLine("WinnerVerify es {0}, PlayerOneWins es {1} y PlayerTwoWins es {2} ",mainTable.WinnerVerify(),mainTable.PlayerOneWins(),mainTable.PlayerTwoWins());
        mainTable.Reset();
        Console.ReadKey();
    }
}while(gameOn);


