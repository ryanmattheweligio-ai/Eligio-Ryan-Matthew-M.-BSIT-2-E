using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main()
    {
        //Display the @ and * player symbol and star symbol in a specific place
        int PlayerX = 5;
        int PlayerY = 5;

        int StarX = 10;
        int StarY = 5;

        // declare score once so it's in scope for the whole method
        int score = 0;
        Random rand = new Random();

        while (true)
        {

            Console.Clear();

            //Display the player symbol
            Console.SetCursorPosition(PlayerX, PlayerY);
            Console.Write("@");
            //Display the star symbol
            Console.SetCursorPosition(StarX, StarY);
            Console.Write("*");
            //Wait for user input before closing the console window

            //Display the Score at Top Left Corner
            Console.SetCursorPosition(112, 0);
            Console.Write("Score: " + score);


            //Player movement
            ConsoleKey key = Console.ReadKey(true).Key;
            if (key == ConsoleKey.W)
            {
                PlayerY--;
            }
            else if (key == ConsoleKey.S)
            {
                PlayerY++;
            }
            else if (key == ConsoleKey.A)
            {
                PlayerX--;
            }
            else if (key == ConsoleKey.D)
            {
                PlayerX++;
            }
            else if (key == ConsoleKey.Escape)
            {
                Environment.Exit(0);
            }
            //Did the player collect the star?
            if (PlayerX == StarX && PlayerY == StarY)
            {
                //Increase the score
                score++;
                StarX = rand.Next(0, Console.WindowWidth);
                StarY = rand.Next(0, Console.WindowHeight-1);
            }

        }
    }   
}
