using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using static System.Console;
using static System.ConsoleColor;

public class Shop : IMenu{  

    #region Crop Information
    private string[] shopItems = new string[5] {"Corn", "Carrots", "Wheat", "Grapes", "Potatoes"};
    private string[] shopItemIcon = new string[5] {"+++", "|>>", "|||", "%%", "0"};
    private int[] shopItemPrices = new int[5] {15,15,10,25,20};
    private int[] shopItemYield = new int[5] {3,5,4,6,1/*Will be randomized between 1-3*/};
    private int[] shopItemYieldPrice = new int[5] {10,8,5,10,6};
    #endregion

    private int currIndex = 0;
    private bool cropSelected = false;
    public void ReadInput(){
        switch(ReadKey().Key){
            case ConsoleKey.Enter:
                    cropSelected = true;
                    Sell();
                break;
            case ConsoleKey.UpArrow:
                CurrentIndex -= 1;
                break;
            case ConsoleKey.DownArrow:
                CurrentIndex += 1;
                break;
        }
    }

    public void Sell(){
        sell:
        Clear();
        PrintOptions();
        ForegroundColor = Green;
        Write("\n\nBuying: ");
        ForegroundColor = Black;
        BackgroundColor = White;
        Write(shopItems[currIndex]);
        ResetColor();
        Write(" (Y/N) ");
        string? input = ReadLine();
        if(input != null && input?.ToLower() == "y"){
            int i = 0;
            increment:
            Clear();
            ForegroundColor = Black;
            BackgroundColor = White;
            Write("\nCount: " + i);
            ResetColor();
            switch(ReadKey().Key){
                case ConsoleKey.UpArrow:
                    i++;
                    goto increment;
                case ConsoleKey.DownArrow:
                    i--;
                    if(i < 0) i=0;
                    goto increment;
                case ConsoleKey.Enter:
                    break;
                default:
                    goto increment;
            }
        } else if (input != null && input?.ToLower() == "n"){
            cropSelected = false;
            return;
        } else{
            goto sell;
        }


        cropSelected = false;
    }


    public void PrintOptions(){
        Title = "Shop";
        for(int i = 0; i < shopItems.Length; i++){
            ForegroundColor = Yellow;
            if(CurrentIndex == i && !cropSelected) {
                ForegroundColor = Black;
                BackgroundColor = White;
                Write("> " + shopItems[i]);
            }
            else Write(shopItems[i]);
            ResetColor();
            Write(" ");
            ForegroundColor = Yellow;
            Write(shopItemIcon[i]);
            ResetColor();
            Write(" : ");
            ForegroundColor = Red;
            Write("$");
            ResetColor();
            Write(shopItemPrices[i] + "\n");
        }
    }

    int CurrentIndex{
        get {return currIndex;}
        set{
            if(value >= shopItems.Length || value < 0)
                return;
            else currIndex = value;
        }
    }
}