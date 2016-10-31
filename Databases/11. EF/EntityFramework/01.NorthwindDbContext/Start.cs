using System;

namespace _01.NorthwindDbContext
{
    public class Start
    {
        static void Main()
        {
            using (var db = new NorthwndEntities())
            {
                var categories = db.Categories;

                foreach (var category in categories)
                {
                    Console.WriteLine(category.CategoryID + ": " + category.CategoryName);
                }
            }
        }
    }
}
