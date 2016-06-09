namespace _03.Tron_3D
{
    using System;
    using System.Collections.Generic;

    public class Tron3D
    {
        static int oldX, oldY, oldZ, x, y;
        static string redMoves, blueMoves;
        static bool[,] used;
        static int currentRedX;
        static int currentRedY;
        static int currentBlueX;
        static int currentBlueY;
        static int redDirection = 0;
        static int blueDirection = 2;

        // Directions:
        // 0 - right;
        // 1 - down
        // 2 - left
        // 3 - up
        // 4 - 0 (%)
        // rotate right = direction++;
        // rotate left = direction--;


        static void Main()
        {
            ReadInput();

            x = oldX;
            y = oldY + oldZ + oldY + oldZ;

            used = new bool[x + 1, y];
            currentRedX = oldX / 2;
            currentRedY = oldY / 2;
            currentBlueX = oldX / 2;
            currentBlueY = oldY + oldZ + oldY / 2;
            var redIndex = 0;
            var blueIndex = 0;

            while (true)
            {
                int NewRedX = currentRedX;
                int NewRedY = currentRedY;

                while (redMoves[redIndex] != 'M')
                {
                    if (redMoves[redIndex] == 'L')
                    {
                        redDirection = RotateLeft(redDirection);
                    }
                    else if (redMoves[redIndex] == 'R')
                    {
                        redDirection = RotateRight(redDirection);
                    }
                    redIndex++;
                }

                MovePlayer(ref NewRedX, ref NewRedY, redDirection);
                redIndex++;

                // BLue
                #region
                int NewBlueX = currentBlueX;
                int NewBlueY = currentBlueY;

                while (redMoves[blueIndex] != 'M')
                {
                    if (redMoves[blueIndex] == 'L')
                    {
                        blueDirection = RotateLeft(blueDirection);
                    }
                    else if (redMoves[blueIndex] == 'R')
                    {
                        blueDirection = RotateRight(blueDirection);
                    }
                    blueIndex++;
                }
                #endregion
                MovePlayer(ref NewBlueX, ref NewBlueY, blueDirection);
                blueIndex++;

            }
        }

        public static void MovePlayer(ref int currentX, ref int currentY, int direction)
        {
            if (direction == 0)
            {
                currentY++;
            }
            else if (direction == 1)
            {
                currentX++;
            }
            else if (direction == 2)
            {
                currentY--;
            }
            else if (direction == 3)
            {
                currentX--;
            }
        }

        static int RotateLeft(int direction)
        {
            int newDirection = direction - 1;
            if (newDirection == -1)
            {
                newDirection = 3;
            }

            return newDirection;
        }

        static int RotateRight(int direction)
        {
            int newDirection = direction + 1;
            if (newDirection == 4)
            {
                newDirection = 0;
            }

            return newDirection;
        }

        public static void ReadInput()
        {
            var xyz = Console.ReadLine().Split(' ');
            oldX = int.Parse(xyz[0]);
            oldY = int.Parse(xyz[1]);
            oldZ = int.Parse(xyz[2]);
            redMoves = Console.ReadLine();
            blueMoves = Console.ReadLine();
        }

        public static bool Looses()
        {
            return true;
        }
    }
}
