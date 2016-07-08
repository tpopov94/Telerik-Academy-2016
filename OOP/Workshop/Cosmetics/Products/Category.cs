namespace Cosmetics.Products
{
    using Cosmetics.Contracts;
    using Cosmetics.Common;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Category : ICategory
    {
        private const int MIN_CATEGORY_LENGTH = 2;
        private const int MAX_CATEGORY_LENGTH = 15;

        private string name;
        private IList<IProduct> cosmeticsList;

        public Category(string name)
        {
            this.Name = name;
            this.cosmeticsList = new List<IProduct>();
        }

        public string Name
        {
            get { return this.name; }
            protected set
            {
                /*if (string.IsNullOrEmpty(value))
                {
                     throw new ArgumentNullException("All properties are mandatory (cannot be null or empty).");
                }*/
                Validator.CheckIfStringIsNullOrEmpty(value, string.Format("Category name must be between {0} and {1} symbols long!", MIN_CATEGORY_LENGTH, MAX_CATEGORY_LENGTH));

                /*if (value.Length < 2 || value.Length > 15)
                {
                    throw new ArgumentException("Category name must be between 2 and 15 symbols long!");
                }*/
                Validator.CheckIfStringLengthIsValid(value, MAX_CATEGORY_LENGTH, MIN_CATEGORY_LENGTH,
                    string.Format("Category name must be between {0} and {1} symbols long!", MIN_CATEGORY_LENGTH, MAX_CATEGORY_LENGTH));

                this.name = value;
            }
        }

        public void AddCosmetics(IProduct cosmetics)
        {
            cosmeticsList.Add(cosmetics);
        }

        public void RemoveCosmetics(IProduct cosmetics)
        {
            cosmeticsList.Remove(cosmetics);
        }

        public string Print()
        {
            var result = new StringBuilder();

            // first line is correct
            result.AppendLine(string.Format("{0} category - {1} {2} in total", this.Name,
                this.cosmeticsList.Count().ToString(),
                this.cosmeticsList.Count != 1 ? "products" : "product"));

            foreach (var item in cosmeticsList.OrderBy(p => p.Brand).ThenByDescending(p => p.Price))
            {
                result.AppendLine(item.ToString());
            }


            return result.ToString().Trim();
        }

    }
}
