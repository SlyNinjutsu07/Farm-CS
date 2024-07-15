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
        else goto farm;

        farm:
        throw new NotImplementedException();*/
        
        string[][] map;
        string[] filetext = File.ReadAllLines("file.txt");

        map = new string[filetext.Length][];

        for(int i = 0; i < filetext.Length; i++){
            map[i] = new string[filetext[i].Length];
            for(int j = 0; j < filetext[i].Length; j++){
                map[i][j] = filetext[i].Substring(j, 1);
            }
        }

        for(int i = 0; i < map.Length; i++){
            for(int j = 0; j < map[i].Length; j++){
                Write(map[i][j]);
            }
            WriteLine();
        }

        ReadKey();
    }
}