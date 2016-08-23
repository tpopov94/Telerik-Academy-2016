namespace Size
{
    using System;

    public class Figure
    {
        private double width;
        private double height;

        public Figure(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width
        {
            get
            {
                return this.width;
            }

            set
            {
                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }

            set
            {
                this.height = value;
            }
        }

        public static Figure GetRotatedSize(Figure figure, double angle)
        {
            double cosinus = Math.Cos(angle);
            double sinus = Math.Sin(angle);
            double cosinusTimesWidth = Math.Abs(cosinus) * figure.Width;
            double cosinusTimesHeight = Math.Abs(cosinus) * figure.Height;
            double sinusTimesWidth = Math.Abs(sinus) * figure.Width;
            double sinusTimesHeight = Math.Abs(sinus) * figure.Height;

            var rotatedFigureWidth = cosinusTimesWidth * sinusTimesHeight;
            var rotatedFigureHeight = cosinusTimesHeight * sinusTimesWidth;

            return new Figure(rotatedFigureWidth, rotatedFigureHeight);
        }
    }
}
