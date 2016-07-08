namespace Cosmetics.Products
{
    using Cosmetics.Contracts;
    using System.Collections.Generic;
    using System.Linq;

    public class ShoppingCart : IShoppingCart
    {
        private ICollection<IProduct> products;

        public ShoppingCart()
        {
            this.products = new List<IProduct>();
        }

        public void AddProduct(IProduct product)
        {
            this.products.Add(product);
        }

        public void RemoveProduct(IProduct product)
        {
            this.products.Remove(product);
        }

        public bool ContainsProduct(IProduct product)
        {
            var contains = this.products.Contains(product);
            return contains;
        }

        public decimal TotalPrice()
        {
            decimal price = 0;

            price = this.products.Sum(p => p.Price);
            //foreach (var item in products)
            //{
            //    price += item.Price;
            //}

            return price;
        }
    }
}
