using System;
using System.IO;

namespace PII_Game_Of_Life
{
    public class GameBoard
    {

        static string url = "C:\\Users\\Augusto\\Documents\\GitHub\\Ejercicios_Expert_SRP_AugustoTano\\Ejercicio 4\\assets\\board.txt"; 
        static string content = File.ReadAllText(url);
        static string[] contentLines = content.Split('\n');
        static bool[,] board = new bool[contentLines.Length, contentLines[0].Length];

        public void ObtenerBoard()
        {
            for (int  y=0; y<contentLines.Length; y++)
            {
                for (int x=0; x<contentLines[y].Length; x++)
                {
                    if(contentLines[y][x]=='1')
                    {
                        board[x,y]=true;
                    }
                }
            }
        }
    }
}
