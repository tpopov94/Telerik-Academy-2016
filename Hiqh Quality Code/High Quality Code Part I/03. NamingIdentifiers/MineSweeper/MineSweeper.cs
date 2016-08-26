namespace MineSweeper
{
    using System;
    using System.Collections.Generic;

    public class MineSweeper
    {
        public static void Main(string[] args)
        {
            const int MAX_SCORE = 35;

            string command = string.Empty;
            char[,] field = CreateField();
            char[,] bombs = PlaceMines();
            int counter = 0;
            bool isMine = false;
            List<Points> topPlayers = new List<Points>(6);
            int row = 0;
            int col = 0;
            bool inGame = true;
            bool maxScoreAchieved = false;

            do
            {
                if (inGame)
                {
                    Console.WriteLine("Welcome to MineSweeper Console game \nTry your skills to find all the fields without bombs. \n" +
                    "Commands:\n \"top\" shows the leaderboard\n \"restart\" starts new game\n \"exit\" extis the game");

                    DrawField(field);
                    inGame = false;
                }

                Console.Write("Enter row and col : ");

                command = Console.ReadLine().Trim();

                if (command.Length >= 3)
                {
                    if (int.TryParse(command[0].ToString(), out row) &&
                        int.TryParse(command[2].ToString(), out col) &&
                        row <= field.GetLength(0) && col <= field.GetLength(1))
                    {
                        command = "turn";
                    }
                }

                switch (command)
                {
                    case "top":
                        LeaderBoard(topPlayers);
                        break;
                    case "restart":
                        field = CreateField();
                        bombs = PlaceMines();
                        DrawField(field);
                        isMine = false;
                        inGame = false;
                        break;
                    case "exit":
                        Console.WriteLine("Goodbye !");
                        break;
                    case "turn":
                        if (bombs[row, col] != '*')
                        {
                            if (bombs[row, col] == '-')
                            {
                                PlayerTurn(field, bombs, row, col);
                                counter++;
                            }

                            if (MAX_SCORE == counter)
                            {
                                maxScoreAchieved = true;
                            }
                            else
                            {
                                DrawField(field);
                            }
                        }
                        else
                        {
                            isMine = true;
                        }

                        break;
                    default:
                        Console.WriteLine("\nInvalid Command\n");
                        break;
                }

                if (isMine)
                {
                    DrawField(bombs);
                    Console.Write("\nHrrrrrr! You are dead! You have scored {0} points. Enter your user name: ", counter);
                    string userName = Console.ReadLine();
                    Points score = new Points(userName, counter);

                    if (topPlayers.Count < 5)
                    {
                        topPlayers.Add(score);
                    }
                    else
                    {
                        for (int i = 0; i < topPlayers.Count; i++)
                        {
                            if (topPlayers[i].PlayerPoints < score.PlayerPoints)
                            {
                                topPlayers.Insert(i, score);
                                topPlayers.RemoveAt(topPlayers.Count - 1);
                                break;
                            }
                        }
                    }

                    topPlayers.Sort((Points r1, Points r2) => r2.PlayerName.CompareTo(r1.PlayerName));
                    topPlayers.Sort((Points r1, Points r2) => r2.PlayerPoints.CompareTo(r1.PlayerPoints));
                    LeaderBoard(topPlayers);

                    field = CreateField();
                    bombs = PlaceMines();
                    counter = 0;
                    isMine = false;
                    inGame = true;
                }

                if (maxScoreAchieved)
                {
                    Console.WriteLine("\nYou have done it !!");
                    DrawField(bombs);
                    Console.WriteLine("Enter your name: ");
                    string userName = Console.ReadLine();
                    Points points = new Points(userName, counter);
                    topPlayers.Add(points);
                    LeaderBoard(topPlayers);
                    field = CreateField();
                    bombs = PlaceMines();
                    counter = 0;
                    maxScoreAchieved = false;
                    inGame = true;
                }
            }
            while (command != "exit");
           
                Console.WriteLine("Made in Bulgaria!");
                Console.Read();
        }

        private static void LeaderBoard(List<Points> points)
        {
            Console.WriteLine("Points:");

            if (points.Count > 0)
            {
                for (int i = 0; i < points.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} kutii", i + 1, points[i].PlayerName, points[i].PlayerPoints);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Empty Leaderboard!\n");
            }
        }

        private static void PlayerTurn(char[,] field, char[,] bombs, int row, int col)
        {
            char bombsCounter = Counter(bombs, row, col);
            bombs[row, col] = bombsCounter;
            field[row, col] = bombsCounter;
        }

        private static void DrawField(char[,] board)
        {
            int rows = board.GetLength(0);
            int cols = board.GetLength(1);

            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");

            for (int i = 0; i < rows; i++)
            {
                Console.Write("{0} | ", i);

                for (int j = 0; j < cols; j++)
                {
                    Console.Write(string.Format("{0} ", board[i, j]));
                }

                Console.Write("|");
                Console.WriteLine();
            }

            Console.WriteLine("   ---------------------\n");
        }

        private static char[,] CreateField()
        {
            int boardRows = 5;
            int boardColumns = 10;
            char[,] board = new char[boardRows, boardColumns];

            for (int i = 0; i < boardRows; i++)
            {
                for (int j = 0; j < boardColumns; j++)
                {
                    board[i, j] = '?';
                }
            }

            return board;
        }

        private static char[,] PlaceMines()
        {
            int rows = 5;
            int cols = 10;

            char[,] field = new char[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    field[i, j] = '-';
                }
            }

            List<int> randomNumbers = new List<int>();

            while (randomNumbers.Count < 15)
            {
                Random random = new Random();
                int nextRandomNumber = random.Next(50);

                if (!randomNumbers.Contains(nextRandomNumber))
                {
                    randomNumbers.Add(nextRandomNumber);
                }
            }

            foreach (int i2 in randomNumbers)
            {
                int col = i2 / cols;
                int row = i2 % cols;

                if (row == 0 && i2 != 0)
                {
                    col--;
                    row = cols;
                }
                else
                {
                    row++;
                }

                field[col, row - 1] = '*';
            }

            return field;
        }

        private static void Math(char[,] field)
        {
            int cols = field.GetLength(0);
            int rows = field.GetLength(1);

            for (int i = 0; i < cols; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    if (field[i, j] != '*')
                    {
                        char counter = Counter(field, i, j);

                        field[i, j] = counter;
                    }
                }
            }
        }

        private static char Counter(char[,] mines, int row, int col)
        {
            int count = 0;
            int rows = mines.GetLength(0);
            int cols = mines.GetLength(1);

            if (rows - 1 >= 0)
            {
                if (mines[rows - 1, col] == '*')
                {
                    count++;
                }
            }

            if (rows + 1 < rows)
            {
                if (mines[rows + 1, col] == '*')
                {
                    count++;
                }
            }

            if (col - 1 >= 0)
            {
                if (mines[rows, col - 1] == '*')
                {
                    count++;
                }
            }

            if (col + 1 < cols)
            {
                if (mines[rows, col + 1] == '*')
                {
                    count++;
                }
            }

            if ((rows - 1 >= 0) && (col - 1 >= 0))
            {
                if (mines[rows - 1, col - 1] == '*')
                {
                    count++;
                }
            }

            if ((rows - 1 >= 0) && (col + 1 < cols))
            {
                if (mines[rows - 1, col + 1] == '*')
                {
                    count++;
                }
            }

            if ((rows + 1 < rows) && (col - 1 >= 0))
            {
                if (mines[rows + 1, col - 1] == '*')
                {
                    count++;
                }
            }

            if ((rows + 1 < rows) && (col + 1 < cols))
            {
                if (mines[rows + 1, col + 1] == '*')
                {
                    count++;
                }
            }

            return char.Parse(count.ToString());
        }
    }
}