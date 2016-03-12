namespace Shapes
{
    using System;

    public abstract class Shape
    {
        private double width;
        private double height;

        // Constructors

        public Shape(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        // Properties

        public double Width
        {
            get { return this.width; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The width of the figure must be a positive number bigger than zero !");
                }
                else
                {
                    this.width = value;
                }
            }
        }

        public double Height
        {
            get { return this.height; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The height of the figure must be a positive number bigger than zero !");
                }
                else
                {
                    this.height = value;
                }
            }
        }
        // Methods

        public abstract double CalculateSurface();
    }
}
