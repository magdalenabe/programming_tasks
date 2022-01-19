using System;

namespace App21
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] emptyBoard = new int[10, 10];
            PrintBoard(emptyBoard);
            Console.WriteLine();
            int[,] gameboard = new int[10, 10];
            DisplayShipsOnGameboard(gameboard, 5);



        }
        static void PrintBoard(int[,] board)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {

                    Console.Write(board[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static void DisplayShipsOnGameboard(int[,] board, int NumberOfShips)
        {
            int add = 0;
            do
            {
                int x = ShipCoordinate();
                int y = ShipCoordinate();
                if (board[x, y] == 0)   
                {
                    board[x, y] = 1;
                    add++;
                }
            }
                while (add != NumberOfShips) ;
            PrintBoard(board);
        }
        static int ShipCoordinate()
        {
                Random rand = new Random();
                int a = rand.Next(0, 10);
                return a;
        }

    }
}
