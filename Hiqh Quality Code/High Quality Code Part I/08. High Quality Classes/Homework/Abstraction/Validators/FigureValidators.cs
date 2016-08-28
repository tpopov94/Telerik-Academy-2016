namespace Abstraction.Validators
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class FigureValidators
    {
        public static void SideValidator(double side)
        {
            if (side <= 0)
            {
                throw new ArgumentException("Figure sides cannot be negative numbers or zero");
            }
        }

        public static void RadiusValidator(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("Circle radius cannot be negative numbers or zero");
            }
        }
    }
}
