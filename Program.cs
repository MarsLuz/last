using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the width of the room: ");
        int width = int.Parse(Console.ReadLine());

        Console.Write("Enter the height of the room: ");
        int height = int.Parse(Console.ReadLine());

        int totalTiles = width * height;

        if (totalTiles % 4 == 0 || totalTiles % 4 == 0)
        {
            Console.WriteLine("Too stuffy!");
        }
        else
        {
            Console.WriteLine("Okay!");
        }
    }
}