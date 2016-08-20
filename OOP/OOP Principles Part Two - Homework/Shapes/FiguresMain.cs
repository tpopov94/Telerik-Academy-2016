/*
    Define abstract class Shape with only one abstract method CalculateSurface() and fields width and height.
    Define two new classes Triangle and Rectangle that implement the virtual method and return the surface of the figure (height * width for rectangle and height * width/2 for triangle).
    Define class Square and suitable constructor so that at initialization height must be kept equal to width and implement the CalculateSurface() method.
    Write a program that tests the behaviour of the CalculateSurface() method for different shapes (Square, Rectangle, Triangle) stored in an array.
*/
namespace Shapes
{
    using System;
    using System.Collections.Generic;

    public class FiguresMain
    {
        public static void Main()
        {
            // Some tests

            var shapesList = new List<Shape>
            {
                new Triangle(4, 5),
                new Rectangle(4, 5),
                new Square(3),
                new Triangle(4.4, 7),
                new Rectangle(12, 5.55),
                new Square(27),
            };

            foreach (var shape in shapesList)
            {
                Console.WriteLine(shape.GetType().Name + " area is: " + shape.CalculateSurface());
            }

            // If you want to check it with array uncomment - it is the same 

            //var shapesList = new Shape[]
            //{
            //    new Triangle(4, 5),
            //    new Rectangle(4, 5),
            //    new Square(3),
            //    new Triangle(4.4, 7),
            //    new Rectangle(12, 5.55),
            //    new Square(27),
            //};

            //foreach (var shape in shapesList)
            //{
            //    Console.WriteLine(shape.GetType().Name + " area is: " + shape.CalculateSurface());
            //}
        }
    }
}
