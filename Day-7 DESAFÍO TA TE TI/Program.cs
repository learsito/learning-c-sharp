Table mainTable = new Table();

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
            mainTable.ShowTable();
            Console.WriteLine("¡Felicidades!");
            Console.WriteLine("Ha ganado {0}.",mainTable.PlayerOneName());
            Console.WriteLine("Presione cualquier tecla para reiniciar el juego...");
            mainTable.Reset();
            Console.ReadKey();
        } else if(mainTable.WinnerVerify() && mainTable.PlayerTwoWins()){
            mainTable.ShowTable();
            Console.WriteLine("¡Felicidades!");
            Console.WriteLine("Ha ganado {0}.",mainTable.PlayerTwoName());
            Console.WriteLine("Presione cualquier tecla para reiniciar el juego...");
            mainTable.Reset();
            Console.ReadKey();
        }else if (mainTable.EveryBoxFilled()){
            mainTable.ShowTable();
            Console.WriteLine("Gato encerrado. Presione cualquier tecla para reiniciar el juego...");
            mainTable.Reset();
            Console.ReadKey();
    }else{
            mainTable.ShowTable();
            System.Console.WriteLine("WinnerVerify es {0}, PlayerOneWins es {1} y PlayerTwoWins es {2} ",mainTable.WinnerVerify(),mainTable.PlayerOneWins(),mainTable.PlayerTwoWins());
            mainTable.Reset();
            Console.ReadKey();
    }
}while(true);


