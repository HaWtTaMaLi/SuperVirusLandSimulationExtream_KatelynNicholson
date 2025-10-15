using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperVirusLandSimulationExtream_KatelynNicholson
{
    //virus =  = X
    //virus (x, y) build index for each virus that spawns
    //grass = green = -
    //water = blue = ~ 
    //mountains = Gray = ^
    //3 starting viruses on grass

    internal class Program
    {

        static string virusAvatar = "X";
        static string grassAvatar = "-";
        static string waterAvatar = "~";
        static string mountainAvatar = "^";
        static char[,] map = new char[20,20];
        List<int> virusData = new List<int>();

        static void Main()
        {

            PrintMap();
        }

        static void PrintMap()
        {
            for (int y = 0; y < map.GetLength(0); y++)
            {

                for (int x = 1; x < map.GetLength(1); x++)
                {
                    char tile = map[y,x];
                    
                    switch (tile)
                    {
                        case '-':
                            Console.BackgroundColor = ConsoleColor.Green;
                            break;
                        case '~':
                            Console.BackgroundColor = ConsoleColor.Blue;
                            break;
                        case '^':
                            Console.BackgroundColor = ConsoleColor.Gray;
                            break;
                    }
                    Console.Write(tile);
                }
            }
        }

        static void GetVirusData(string virusData)
        {
            //save locations on the map that the virus touched and store it
        }

        static void VirusSpawner()
        {
            //check virus data and check to see if virus location was stored
            //if yes - 10% chance to spawn there if no virus 
            //if no - normal random gen
            //check to see if a virus is already stored
        }

    }
}
