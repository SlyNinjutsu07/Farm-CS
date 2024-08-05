using System;
using static System.Console;
using static System.ConsoleColor;


class Game{
    public static void Main(string[] args){
        Title = "Farm Game";

        /* MainMenu mm = new MainMenu();
        mainmenu:
        mm.PrintOptions();
        mm.ReadInput();
        Clear();
        if(!mm.GameStart) goto mainmenu;
        else goto farm;*/

        /*Farm f = new Farm();
        farm:
        f.PrintFarm();
        f.Move();
        Clear();
        goto farm;*/

        //inv:
        Inventory i = new Inventory();
        i.PrintOptions();
        //Clear();
        //goto inv;

        //ReadKey();
    }
}