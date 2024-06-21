using System;
using static System.Console;
using static System.ConsoleColor;

public class MainMenu{

    private bool gameStart = false;
    private const string menuName = @"

 ██████╗ ██╗ ██╗     ███████╗ █████╗ ██████╗ ███╗   ███╗     ██████╗  █████╗ ███╗   ███╗███████╗
██╔════╝████████╗    ██╔════╝██╔══██╗██╔══██╗████╗ ████║    ██╔════╝ ██╔══██╗████╗ ████║██╔════╝
██║     ╚██╔═██╔╝    █████╗  ███████║██████╔╝██╔████╔██║    ██║  ███╗███████║██╔████╔██║█████╗  
██║     ████████╗    ██╔══╝  ██╔══██║██╔══██╗██║╚██╔╝██║    ██║   ██║██╔══██║██║╚██╔╝██║██╔══╝  
╚██████╗╚██╔═██╔╝    ██║     ██║  ██║██║  ██║██║ ╚═╝ ██║    ╚██████╔╝██║  ██║██║ ╚═╝ ██║███████╗
 ╚═════╝ ╚═╝ ╚═╝     ╚═╝     ╚═╝  ╚═╝╚═╝  ╚═╝╚═╝     ╚═╝     ╚═════╝ ╚═╝  ╚═╝╚═╝     ╚═╝╚══════╝
                                                                                                

";
    private string[] menuOptions = {"Play", "Settings", "About", "Controls", "Quit"}; 
    private int currIndex;
    public void ReadInput(){
        switch(ReadKey().Key){
            case ConsoleKey.Enter:
                OptionSelected();
                break;
            case ConsoleKey.UpArrow:
                CurrentIndex -= 1;
                break;
            case ConsoleKey.DownArrow:
                CurrentIndex += 1;
                break;
            default: 
                break;
        }
    }
    
    private void OptionSelected(){
        switch(CurrentIndex){
            case 0:
                gameStart = true;
                break;
            case 1:
                Clear();
                ForegroundColor = Green;
                Write("Settings");
                ForegroundColor = White;
                Write("\n\nNo availabe settings yet.");
                Quit();
                break;
            case 2:
                Clear();
                Write("This game is a simple farm game where you can nurture crops in your own farm, " 
                + "\npurchase new crops, and sell them for profit!");
                Quit();
                break;
            case 3:
                Clear();
                ForegroundColor = Green;
                Write("Controls");
                ForegroundColor = White;
                Write("\n\nUp Arrow: Move up in the menu" +
                "\nDown Arrow: Move down in the menu"
                +"\nEnter: Select choice");
                Quit();
                break;
            case 4:
                Environment.Exit(0);
                return;
        }
    }
    public void PrintOptions(){
        ForegroundColor = Green;
        Write(menuName);
        
        for(int i = 0; i < menuOptions.Length; i++){
            if(CurrentIndex == i){
                ForegroundColor = White;
                Write(">");
                ResetColor();
                ForegroundColor = Green;
                Write(" " + menuOptions[i] + "\n");
            } else Write(menuOptions[i] + "\n");
        }
    }

    private void Quit(){
        ForegroundColor = Black;
        BackgroundColor = White;
        Write("\n\n> Quit");
        ResetColor();
        reinput:
        if(ReadKey().Key == ConsoleKey.Enter) return;
        else goto reinput;
    }

    public int CurrentIndex{
        get {return currIndex;}
        set{
            if(value >= menuOptions.Length || value < 0) return;
            else currIndex = value;
        }
    }

    public bool GameStart{
        get{return gameStart;}
    }
}