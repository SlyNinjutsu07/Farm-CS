using System;
using static System.Console;
using static System.ConsoleColor;

public class Farm{

    //Player Info
    private char player = 'X';
    private int playerX, playerY;

    //Highlighted Crop
    private int selectedCropX = -1, selectedCropY = -1;

    //Farm
    private string[,] farm = 
    {
        {" "," "," "," "},
        {" ","0","0"," "},
        {" ","0","0"," "},
        {" "," "," "," "},
        {" ","0","0"," "},
        {" ","0","0"," "},
        {" "," "," "," "}
    };

    public Farm(){
        playerX = 0; playerY = 0;
    }
    public void PrintFarm(){
        farm[playerY, playerX] = player.ToString();

        for (int i = 0; i < farm.GetLength(0);i++)
        {
            for(int j = 0; j < farm.GetLength(1); j++)
            {
                if(farm[i,j] != player.ToString())
                {
                    ForegroundColor = Yellow;
                    if(CropSelected(j,i))
                    {
                        BackgroundColor = White;
                        Write(farm[i, j]);
                        ResetColor();
                        Write(" ");
                    } else Write(farm[i, j] + " ");
                    ResetColor();
                } else if(farm[i,j] == player.ToString())
                {
                    ForegroundColor = Red;
                    Write(farm[i,j] + " ");
                    ResetColor();
                } else Write(farm[i,j] + " ");
            }
            WriteLine();
        }
    }

    public void Move(){
        switch(ReadKey().Key){
            case ConsoleKey.UpArrow:
            SetPos(0, -1);
            break;
            case ConsoleKey.DownArrow:
            SetPos(0, 1);
            break;
            case ConsoleKey.LeftArrow:
            SetPos(-1, 0);
            break;
            case ConsoleKey.RightArrow:
            SetPos(1, 0);
            break;
            case ConsoleKey.Escape:
                Environment.Exit(0);
                break;
        }
    }
    
    public void SetPos(int x, int y){
        try{
            if (farm[playerY + y, playerX + x] != " ")
            {
                selectedCropX = playerX + x;
                selectedCropY = playerY + y;
                return;
            }
            else
            {
                farm[playerY, playerX] = " ";
                farm[playerY + y, playerX + x] = player.ToString();
                selectedCropX = -1;
                selectedCropY = -1;
            }
        } catch (IndexOutOfRangeException){
            Write("\n\nOut of bounds!");
            ReadKey();
            return;
        }
        playerX += x;
        playerY += y;
    }

    private bool CropSelected(int cropX, int cropY)
    {
        if(selectedCropX != 0 && selectedCropY != 0)
        {
            if (selectedCropX == cropX && selectedCropY == cropY)
                return true;
        }
        return false;
    }

    
    
}