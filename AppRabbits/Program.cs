using System;

namespace AppRK
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is a 2-4 player game. How many players will play?");
            var numberOfPlayers = int.Parse(Console.ReadLine());
            var players = new int[numberOfPlayers];
            int rabbitsInTheHole = 100;
            int[] entries = new int[5];


            Console.WriteLine();
            //while rabbits & entry array


            while (rabbitsInTheHole > 0 || IsRabbitInAnyHole(entries))
            {
                for (int playerIndex = 0; playerIndex < players.Length; playerIndex++)
                {
                    int rollResult = RollTheDice();
                    Console.WriteLine($"Player {playerIndex} rolled {rollResult + 1 }");
                    if (rollResult + 1 == 6)
                    {
                        if (rabbitsInTheHole > 0)
                        {
                            rabbitsInTheHole--;
                            players[playerIndex]++;
                            Console.WriteLine($" Player {playerIndex} takes the rabbit.");
                        }
                        else
                        {
                            Console.WriteLine("There's no more rabbits in the hole :(");
                        }
                    }
                    else
                    {
                        if (entries[rollResult] == 1)
                        {
                            entries[rollResult] = 0;
                            players[playerIndex]++;
                            Console.WriteLine($" Player {playerIndex} takes the rabbit from entry {rollResult + 1}.");
                        }
                        else
                        {
                            if (rabbitsInTheHole > 0)
                            {
                                rabbitsInTheHole--;
                                entries[rollResult] = 1;
                                Console.WriteLine($" Player {playerIndex} moves the rabbit to entry {rollResult + 1}.");
                            }

                            else
                            {
                                Console.WriteLine("There's no more rabbits in the hole :(");
                            }

                        }
                    }
                }
            }

            Console.WriteLine("There's no more rabbits in the game.");
            for (int playerIndex = 0; playerIndex < players.Length; playerIndex++)
            {
                Console.WriteLine($"Player {playerIndex} has {players[playerIndex]} points");

            }
        }
        static int RollTheDice()
        {
            Random rand = new Random();
            int roll = rand.Next(0, 6);
            return roll;
        }

        static bool IsRabbitInAnyHole(int[] entries)
        {
            for (int i = 0; i < entries.Length; i++)
            {
                if (entries[i] > 0)
                {
                    return true;
                }

            }
            return false;
        }
    }
}
