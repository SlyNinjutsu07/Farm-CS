using System;
using static System.Console;
using static System.ConsoleColor;


class Game{
    public static void Main(string[] args){
        Title = "Farm Game";

        MainMenu mm = new MainMenu();
        mainmenu:
        mm.PrintOptions();
        mm.ReadInput();
        Clear();
        if(!mm.GameStart) goto mainmenu;
        else goto farm;

        farm:
        throw new NotImplementedException();
        // Shop shop = new Shop();

        // // game:
        // // shop.PrintOptions();
        // // shop.ReadInput();
        // // Clear();
        // // goto game;

        //ReadKey();
    }
}