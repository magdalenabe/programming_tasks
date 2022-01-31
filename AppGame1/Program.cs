using System;

namespace AppGame1
{
    class Program
    {
        static void Main(string[] args)
        {
            var players = new Player[NumberOfPlayers()];

            var isFinished = false;
            for (int i = 0; i < players.Length; i++)
            {
                players[i] = new Player($"{i + 1}");
            }
            do
            {
                for (var playerIndex = 0; playerIndex < players.Length; playerIndex++)
                {
                    int rollResult = RollTheDice();
                    players[playerIndex].FieldNumber(rollResult);

                    if (IsTheFieldEven(players[playerIndex].GetFieldNumber()))
                    {
                        int spinPoints = SpinTheWheel();
                        players[playerIndex].AddPoints(spinPoints);
                    }
                    if (players[playerIndex].GetFieldNumber() >= 96)
                    {
                        isFinished = true;
                        break;
                    }
                }
            } while (!isFinished);
            Console.WriteLine("End of the game.");
            Console.WriteLine();
            for (int i = 0; i < players.Length; i++)
            {
                Console.WriteLine($"Player {players[i].GetName()} has {players[i].GetPoints()} points.");
            }
        }
        static int NumberOfPlayers()
        {
            Console.WriteLine("This is a 2-4 players game. How many players will play?");
            return int.Parse(Console.ReadLine());
        }
        static int RollTheDice()
        {
            Random rand = new Random();
            int roll = rand.Next(1, 7);
            return roll;
        }
        static bool IsTheFieldEven(int value)
        {
            if (value % 2 == 0)
            {
                return true;
            }
            return false;
        }
        static int SpinTheWheel()
        {
            Random spin = new Random();
            int probability = spin.Next(0, 100);
            if (probability < 5)
            {
                return 5;
            }
            if (probability >= 75)
            {
                return 3;
            }
            return 1;
        }
    }

    class Player
    {
        private string _name;
        private int _points;
        private int _field;

        public Player(string name)
        {
            _name = name;
        }
        public void AddPoints(int points)
        {
            _points += points;
            Console.WriteLine($"Player {_name} got {_points} points.");
        }
        public void FieldNumber(int field)
        {
            _field += field;
            Console.WriteLine($"Player {_name} is moved to field number {_field}");
        }
        public string GetName()
        {
            return _name;
        }
        public int GetFieldNumber()
        {
            return _field;
        }
        public int GetPoints()
        {
            return _points;
        }
    }

}