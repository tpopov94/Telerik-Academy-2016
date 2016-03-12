namespace MobilePhoneProject
{
    using System;

    class Display
    {
        private double size;  // Task One
        private ulong numberOfColors; // Task One

        //Parametless Constructor 
        public Display() // Task Two
        {
            this.size = 0;
            this.numberOfColors = 0;
        }

        public Display(double size, ulong numberOfColors) // Task Two
        {
            this.size = size;
            this.numberOfColors = numberOfColors;
        }

        //Properties:  // Task 5

        public double Size
        {
            get { return this.size; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The size of the display cannot be negative number or 0");
                }
                else
                {
                    this.size = value;
                }
            }
        }

        public ulong NumberOfColors
        {
            get { return this.numberOfColors; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The display must have at least one color");
                }
                else
                {
                    this.numberOfColors = value;
                }
            }
        }


        //Methods
        /* public override string ToString()
         {
             return String.Format("Diagonal length: {0}, Number of colors: {1}",
             this.size, this.numberOfColors);
         }*/
    }
}
