namespace IfStatements
{
    using System;

    public class IfStatement
    {
        public void Move()
        {
            double x;
            double y;

            bool isValidNumberX = double.TryParse(Console.ReadLine(), out x);

            bool isValidNumberY = double.TryParse(Console.ReadLine(), out y);

            if (!(isValidNumberX && isValidNumberY))
            {
                throw new ArgumentException("Invalid number");
            }

            if (this.CheckIfInRange(x) && this.CheckIfInRange(y))
            {
                bool canVisitCell = this.CheckCell();
                if (canVisitCell)
                {
                    this.VisitCell();
                }
            }
        }

        private bool CheckIfInRange(double number)
        {
            const double MinNumber = -100;
            const double MaxValue = 100;

            if (MinNumber <= number && number <= MaxValue)
            {
                return true;
            }

            return false;
        }

        private void VisitCell()
        {
            throw new NotImplementedException();
        }

        private bool CheckCell()
        {
            throw new NotImplementedException();
        }
    }
}