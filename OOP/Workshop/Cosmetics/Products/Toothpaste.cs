namespace Cosmetics.Products
{
    using Cosmetics.Contracts;
    using Cosmetics.Common;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Toothpaste : Product, IToothpaste
    {
        private const int MIN_INGREDIENT_LENGTH = 4;
        private const int MAX_INGREDIENT_LENGTH = 12;

        private string ingredients;
        private IList<string> ingredientsList;

        public Toothpaste(string name, string brand, decimal price, Common.GenderType gender, IList<string> ingredients)
        {
            this.Name = name;
            this.Brand = brand;
            this.Price = price;
            this.Gender = gender;
            this.IngredientsList = ingredients;
        }

        public string Ingredients
        {
            get
            { return this.ingredients; }
            protected set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("All properties in the above interfaces are mandatory (cannot be null or empty).");
                }
                /* if (value.Length < 4 || value.Length > 12)
                 {
                     throw new ArgumentException("Each ingredient must be between 4 and 12 symbols long!");
                 }*/
                Validator.CheckIfStringLengthIsValid(value, MAX_INGREDIENT_LENGTH, MIN_INGREDIENT_LENGTH,
                    string.Format("Each ingredient must be between {0} and {1} symbols long!", MIN_INGREDIENT_LENGTH, MAX_INGREDIENT_LENGTH));

                this.ingredients = value;
            }
        }

        public IList<string> IngredientsList { get; set; }

        protected void AddIgredients(string ingredients)
        {
            this.ingredientsList.Add(ingredients);
        }

        public override string ToString()
        {
            var result = new StringBuilder();

            result.AppendLine(string.Format("- {0} - {1}:", this.Brand, this.Name));
            result.AppendLine(string.Format("  * Price: ${0}", this.Price));
            result.AppendLine(string.Format("  * For gender: {0}", this.Gender));
            result.AppendLine(string.Format("  * Ingredients: {0}", string.Join(", ", this.IngredientsList)));

            return result.ToString().Trim();
        }
    }
}
