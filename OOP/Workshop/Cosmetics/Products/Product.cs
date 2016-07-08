namespace Cosmetics.Products
{
    using Common;
    using Cosmetics.Contracts;
    using System;
    using System.Text;

    public abstract class Product : IProduct
    {
        private const int MIN_PRODUCT_NAME = 3;
        private const int MIN_BRAND_NAME = 2;
        private const int MAX_PRODUCT_NAME = 10;
        private const int MAX_BRAND_NAME = 10;

        private string name;
        private string brand;

        public string Name
        {
            get { return this.name; }
            protected set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(GlobalErrorMessages.StringCannotBeNullOrEmpty);
                }
                /* if (value.Length < 3 || value.Length > 10)
                 {
                     throw new ArgumentException("Product name must be between 3 and 10 symbols long!");
                 }*/
                Validator.CheckIfStringLengthIsValid(value, MAX_PRODUCT_NAME, MIN_PRODUCT_NAME,
                    string.Format("Product name must be between {0} and {1} symbols long!", MIN_PRODUCT_NAME, MAX_PRODUCT_NAME));

                this.name = value;
            }
        }

        public string Brand
        {
            get { return this.brand; }
            protected set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("All properties in the above interfaces are mandatory (cannot be null or empty).");
                }
                /* if (value.Length < 2 || value.Length > 10)
                 {
                     throw new ArgumentException("Product brand must be between 2 and 10 symbols long!");
                 }*/
                Validator.CheckIfStringLengthIsValid(value, MAX_BRAND_NAME, MIN_BRAND_NAME,
                    string.Format("Product brand must be between {0} and {1} symbols long!", MIN_BRAND_NAME, MAX_BRAND_NAME));

                this.brand = value;
            }
        }

        public virtual decimal Price { get; protected set; }

        public Common.GenderType Gender { get; protected set; }

        public string Print()
        {
            var result = new StringBuilder();

            result.AppendLine(string.Format("- {0} - {1}:", this.Brand, this.Name));
            result.AppendLine(string.Format("  * Price: ${0}", this.Price));
            result.AppendLine(string.Format("  * For gender: {0}", this.Gender));
            return result.ToString();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
