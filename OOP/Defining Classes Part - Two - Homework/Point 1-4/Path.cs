namespace Point_1_4
{
    using System.Collections.Generic;


    public class Path // Task 4
    {
        private List<Point> pointList;

        //Constructors
        public Path()
        {
            this.PointList = new List<Point>();
        }

        // Properties
        public List<Point> PointList
        {
            get { return this.pointList; }
            set { this.pointList = value; }
        }

        // Methods

        public void AddPoint(Point point)
        {
            this.pointList.Add(point);
        }
        public void RemovePoint(Point point)
        {
            this.pointList.Remove(point);
        }
    }
}
