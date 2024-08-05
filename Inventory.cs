using System;
using static System.Console;

public class Inventory{

    private string title = @"
 ____  ____   __ __    ___  ____   ______   ___   ____   __ __ 
|    ||    \ |  |  |  /  _]|    \ |      | /   \ |    \ |  |  |
 |  | |  _  ||  |  | /  [_ |  _  ||      ||     ||  D  )|  |  |
 |  | |  |  ||  |  ||    _]|  |  ||_|  |_||  O  ||    / |  ~  |
 |  | |  |  ||  :  ||   [_ |  |  |  |  |  |     ||    \ |___, |
 |  | |  |  | \   / |     ||  |  |  |  |  |     ||  .  \|     |
|____||__|__|  \_/  |_____||__|__|  |__|   \___/ |__|\_||____/ 
                                                               ";

    private List<string> inventory = new List<string>();
    private int currentSelectedIndex = -1;

    public void ReadInput(){
        switch (ReadKey().Key)
        {
            case ConsoleKey.UpArrow:
                break;
            case ConsoleKey.DownArrow:
                break;
            case ConsoleKey.Enter:
                break;
        }
    }

    public void PrintOptions(){
        WriteLine(title+ "\n\n");
        for (int i = 0; i < inventory.Count; i++) { 
            if(i == currentSelectedIndex)
            {
                BackgroundColor = ConsoleColor.White;
                ForegroundColor = ConsoleColor.Black;
                Write(inventory[i] + "\n");
            } else Write(inventory[i] + "\n");
        }
    }

    public int CurrentIndex{
        get;
        set;
    }
}