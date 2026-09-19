using System;
namespace CharacterLesson
{
    class Program
    {
        const int GridWidth = 10;
        const int GridHeight = 10;

        static void Main(string[] args)

        {
            int playerX = GridWidth / 2;
            int playerY = GridHeight / 2;
            bool running = true;

            Console.WriteLine("Move with W/A/S/D, then press Enter. Type Q to quit.");

            while (running)
            {
                DrawGrid(playerX, playerY);

                Console.Write("Move: ");
                string input = Console.ReadKey().KeyChar.ToString();
                

                switch (input)
                {
                    case "w": 
                       playerY = Math.Max(0, playerY - 1); 
                       break;
                    case "s": 
                        playerY = Math.Min(GridHeight - 1, playerY + 1); 
                        break;
                    case "a": 
                        playerX = Math.Max(0, playerX - 1); 
                        break;
                    case "d": 
                        playerX = Math.Min(GridWidth - 1, playerX + 1); 
                        break;
                    case "q": 
                        running = false; 
                        break;
                    default:
                        Console.WriteLine("Unknown command. Use W, A, S, D, or Q.");
                        break;
                }
            }

            Console.WriteLine("Thanks for playing!");
        }
        static void DrawGrid(int playerX, int playerY)
        {
            try { Console.Clear(); } catch { }

            for (int y = 0; y < GridHeight; y++)
            {
                for (int x = 0; x < GridWidth; x++)
                {
                    Console.Write(x == playerX && y == playerY ? '@' : '.');
                }
                Console.WriteLine();
            }
        }
    }
}