namespace Cosmetics.Products
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    
    using Cosmetics.Contracts;
    using Cosmetics.Common;

    public class ShoppingCart : IShoppingCart
    {
        private ICollection<IProduct> products;

        public ShoppingCart()
        {
            this.products = new List<IProduct>();
        }

        public void AddProduct(IProduct product)
        {
            Validator.CheckIfNull(product, "You cannot add null product in the shopping cart");

            this.products.Add(product);
        }

        public void RemoveProduct(IProduct product)
        {
            this.products.Remove(product);
        }

        public bool ContainsProduct(IProduct product)
        {
            Validator.CheckIfNull(product, "The product is null");

            return this.products.Contains(product);
        }

        public decimal TotalPrice()
        {
            decimal totalPrice = this.products.Sum(p => p.Price);

            return totalPrice;
        }
    }
}
