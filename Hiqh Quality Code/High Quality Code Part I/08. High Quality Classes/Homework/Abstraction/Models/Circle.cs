namespace Abstraction
{
    using System;
    using Validators;

    public class Circle : Figure
    {
        private double radius;

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        /// <exception cref="ArgumentException" accessor="set">Radius must be a positive number</exception>
        public double Radius
        {
            get
            {
                return this.radius;
            }

            private set
            {
                FigureValidators.RadiusValidator(value);

                this.radius = value;
            }
        }

        public override double CalculatePerimeter()
        {
            double perimeter = 2 * Math.PI * this.Radius;

            return perimeter;
        }

        public override double CalculateSurface()
        {
            double area = Math.PI * this.Radius * this.Radius;

            return area;
        }
    }
}
