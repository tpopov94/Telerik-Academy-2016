using System.IO;

namespace Point_1_4
{
    public static class PathStorage // Task 4
    {
        public static void SavePath(Path path, string pathIdentifier) //saves the file in the main project directory
        { 
            using (StreamWriter sw = new StreamWriter("..//..//path" + pathIdentifier + ".txt"))
            {

                for (int i = 0; i < path.PointList.Count; i++)
                {
                    sw.WriteLine(path.PointList[i]);
                }

            }
        }


        public static Path LoadPath(string filePath)
        {
            Path path = new Path();

            using (StreamReader sr = new StreamReader(filePath))
            {
                while (sr.EndOfStream == false)
                {
                    string nextPointTxt = sr.ReadLine();
                    Point nextPoint = Point.Parse(nextPointTxt);
                    path.AddPoint(nextPoint);
                }
            }
            return path;
        }
    }
}
