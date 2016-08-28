namespace Abstraction
{
    using Validators;

    public class Rectangle : Figure
    {
        private double height;
        private double width;

        public Rectangle(double height, double width)
        {
            this.Height = height;
            this.Width = width;
        }

        /// <exception cref="ArgumentException" accessor="set">Height must be a positive number</exception>
        public double Height
        {
            get
            {
                return this.height;
            }

            private set
            {
                FigureValidators.SideValidator(value);

                this.height = value;
            }
        }

        /// <exception cref="ArgumentException" accessor="set">Width must be a positive number</exception>
        public double Width
        {
            get
            {
                return this.width;
            }

            private set
            {
                FigureValidators.SideValidator(value);

                this.width = value;
            }
        }

        public override double CalculatePerimeter()
        {
            var perimeter = (2 * this.Height) + (2 * this.Width);

            return perimeter;
        }

        public override double CalculateSurface()
        {
            var area = this.Width * this.Height;

            return area;
        }
    }
}
