using System;

namespace App21
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] emptyArray = new int[10, 10];
            DisplayBoard(emptyArray);
            Console.WriteLine();
            int[,] gameboard = new int[10, 10];
            int numberOfShips = 2;
            AddShipsToBoard(gameboard, numberOfShips);
            DisplayBoard(gameboard);
            int shot = 0;
            while (shot < numberOfShips)
            {
                int x = GetCoordinate("x");
                int y = GetCoordinate("y");
                if (gameboard[x - 1, y - 1] == 1)
                {
                    Console.WriteLine("You shot a ship, keep on");
                    shot++;
                    if (shot == numberOfShips)
                    {
                        Console.WriteLine("Great, you shot all ships");
                    }
                }
                else
                {
                    Console.WriteLine("Sorry, you've missed");
                }
            }
        }

        static void AddShipsToBoard(int[,] board, int numberOfShips)
        {
            var add = 0;
            do
            {
                var x = GetRandomNumber();
                var y = GetRandomNumber();
                if (board[x, y] == 0)
                {
                    board[x, y] = 1;
                    add++;
                }

            }
            while (add < numberOfShips);
        }
        static void DisplayBoard(int[,] board)
        {
            for (int x = 0; x < board.GetLength(0); x++)
            {

                for (int y = 0; y < board.GetLength(1); y++)
                {

                    Console.Write(board[x, y] + " ");
                }
                Console.WriteLine();
            }
        }
        static int GetRandomNumber()
        {
            Random rand = new Random();
            int a = rand.Next(0, 10);
            return a;
        }
        static int GetCoordinate(string coordinateName)
        {
            int coordinate = 0;
            while (coordinate <= 0 || coordinate > 10)
            {
                Console.WriteLine($"Specify coordinate {coordinateName}:");
                var result = int.TryParse(Console.ReadLine(), out coordinate);
                if (result == false)
                {
                    Console.WriteLine("Specify value is not a proper number");
                }
                else if (coordinate <= 0 || coordinate > 10)
                {
                    Console.WriteLine("Specify the number between 1 and 10");
                }
            }
            return coordinate;
        }
    }
}
