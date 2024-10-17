using System;
using Test2;

class Program
{
    static Room[] map = new Room[4];
    static int pos = 0;

    static void Init()
    {
        Room r0 = new Room("Game Room", -1, 2, -1, 1);
        Room r1 = new Room("Bath Room", -1, 3, 0, -1);
        Room r2 = new Room("Bed Room", 0, -1, -1, 3);
        Room r3 = new Room("Kitchen Room", 1, -1, 2, -1);
        map[0] = r0;
        map[1] = r1;
        map[2] = r2;
        map[3] = r3;
    }

    static void MoveTo(int num)
    {
        if (num == -1)
        {
            Console.WriteLine("No Exit!");
        }
        else
        {
            pos = num;
            Console.WriteLine("You have moved to the " + map[pos].Name + " room.");
        }
    }

    static void Main()
    {
        Init();
        Console.WriteLine("Welcome to the game!");
        Console.WriteLine("You are in the " + map[pos].Name + " room.");

        string input;
        Room r;
        int exit;

        do
        {
            r = map[pos];
            Console.WriteLine("Where do you want to go? (n/s/w/e or q to quit): ");
            input = Console.ReadLine().ToLower(); 

            switch (input)
            {
                case "n":
                    exit = r.North;
                    break;
                case "s":
                    exit = r.South;
                    break;
                case "w":
                    exit = r.West;
                    break;
                case "e":
                    exit = r.East;
                    break;
                default:
                    exit = -1; // Invalid input
                    break;
            }

            MoveTo(exit);

        } while (input != "q");

        Console.WriteLine("Goodbye!");
    }
}
