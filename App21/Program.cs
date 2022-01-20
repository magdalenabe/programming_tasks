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
            AddShipsToBoard(gameboard, 10);
            DisplayBoard(gameboard);



        }
   
        static void AddShipsToBoard(int[,] board, int numberOfShips)
        {
            //for (int index = 0; index < numberOfShips; index++)
            //{
            //    var x = GetRandomNumber();
            //    var y = GetRandomNumber();
            //    board[x, y] = 1;

            //} 
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

        static void DisplayBoard(int [,] board)
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
    }
}
