namespace Cosmetics.Products
{
    using Common;
    using Cosmetics.Contracts;
    using System.Text;

    public class Shampoo : Product, IShampoo
    {
        private decimal price;

        public Shampoo(string name, string brand, decimal price, Common.GenderType gender, uint milliliters, Common.UsageType usage)
        {
            this.Name = name;
            this.Brand = brand;
            this.Price = price;
            this.Gender = gender;
            this.Milliliters = milliliters;
            this.Usage = usage;
        }

        public override decimal Price
        {
            get
            {
                return this.price * this.Milliliters;
            }
            protected set
            {
                this.price = value;
            }
        }
        public uint Milliliters { get; protected set; }

        public UsageType Usage { get; protected set; }

        public override string ToString()
        {
            var result = new StringBuilder();

            result.AppendLine(string.Format("- {0} - {1}:", this.Brand, this.Name));
            result.AppendLine(string.Format("  * Price: ${0}", this.Price));
            result.AppendLine(string.Format("  * For gender: {0}", this.Gender));
            result.AppendLine(string.Format("  * Quantity: {0} ml", this.Milliliters));
            result.AppendLine(string.Format("  * Usage: {0}", this.Usage));

            return result.ToString().Trim();
        }
    }
}
