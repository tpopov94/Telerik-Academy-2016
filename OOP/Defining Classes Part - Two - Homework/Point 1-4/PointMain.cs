namespace Point_1_4
{
    using System;

    class PointMain
    {
        static void Main()
        {
            //var p1 = new Point(3, 5, 6);            // Some object from the point class for task 1
            //var p2 = new Point(2, 3.4, 0);
            //Console.WriteLine(p1.ToString());
            //Console.WriteLine(p2.ToString());

            //var zeroPoint = new Point();           // Zero point for Task 2
            //Console.WriteLine(zeroPoint.ToString());

            //var distance = Distance.CalculateDistance(p1, p2);  //Task 3
            //Console.WriteLine("The distance between the two points is: {0}", distance);

            Console.WriteLine(new string('-', 50));

            Path test = new Path();
            Point point1 = new Point(1.5, 2.5, 3.5); //creating points for testing Path.cs
            Point point2 = new Point(-1, 2, 7);
            Point point3 = new Point(4, 2, 3);
            Point point4 = new Point(-5, -4, 3);
            Point point5 = new Point(1.25, 2.375, 3);

            test.AddPoint(point1);      // Adding the test points using Path.cs methods
            test.AddPoint(point2);
            test.AddPoint(point3);
            test.AddPoint(point4);
            test.AddPoint(point5);

            PathStorage.SavePath(test, "sample"); //saving the test points to the file "pathsample.txt"

            Path loadedPath = PathStorage.LoadPath(@"../../pointsample.txt"); //loading the saved file and printing the points

            Console.WriteLine("The points from the text file are: ");
            for (int i = 0; i < loadedPath.PointList.Count; i++)
            {
                Console.WriteLine("Point {0}: {1}", i + 1, loadedPath.PointList[i].ToString());
            }
        }
    }
}
