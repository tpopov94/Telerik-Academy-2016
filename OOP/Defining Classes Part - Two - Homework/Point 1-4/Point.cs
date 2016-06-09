namespace Point_1_4
{
    using System;
    using System.Text;

    public class Point
    {
        private static readonly Point zeroPoint; // Task 2


        private double x; // Task 1
        private double y; // Task 1
        private double z; // Task 1

        // Constructors
        // Parametless Construcotr

        public Point()
        {

        }

        static Point() // Task 2
        {
            zeroPoint = new Point(0, 0, 0);
        }

        public Point(double x, double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        // Properties

        public double X  // Task 1
        {
            get { return this.x; }
            set { this.x = value; }
        }

        public double Y // Task 1
        {
            get { return this.y; }
            set { this.y = value; }
        }

        public double Z // Task 1
        {
            get { return this.z; }
            set { this.z = value; }
        }

        public static Point ZeroPoint
        {
            get { return zeroPoint; }
        }

        // Methods 

        public override string ToString()
        {
            return string.Format("X = {0}, Y = {1}, Z = {2}!", this.X, this.Y, this.Z);
        }
        public static Point Parse(string input) //method for parsing the 3dPoints from the saved txt file
        {
            StringBuilder coordinates = new StringBuilder();
            double[] xyz = new double[3];
            int xyzIndex = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (Char.IsDigit(input[i]) || input[i] == '-')
                {

                    while (i < input.Length && (Char.IsDigit(input[i]) || input[i] == '-' || input[i] == '.'))
                    {
                        coordinates.Append(input[i]);
                        i++;
                    }
                }

                if (coordinates.Length > 0)
                {
                    double coord = double.Parse(coordinates.ToString());
                    xyz[xyzIndex] = coord;
                    xyzIndex++;
                    coordinates.Clear();
                }
            }

            return new Point(xyz[0], xyz[1], xyz[2]);
        }
    }
}
