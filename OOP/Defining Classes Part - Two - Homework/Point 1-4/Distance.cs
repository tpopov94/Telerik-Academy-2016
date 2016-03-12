namespace Point_1_4
{
    using System;

    public static class Distance //Task 3
    {
        public static double CalculateDistance(Point pointOne, Point pointTwo)
        {
            double distance = 0;
            distance = Math.Sqrt((pointOne.X - pointTwo.X) * (pointOne.X - pointTwo.X) +
                                (pointOne.Y - pointTwo.Y) * (pointOne.Y - pointTwo.Y) +
                                (pointOne.Z - pointTwo.Z) * (pointOne.Z - pointTwo.Z));
            return distance;
        }
    }
}
