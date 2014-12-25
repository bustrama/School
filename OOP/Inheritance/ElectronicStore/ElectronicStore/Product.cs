using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ElectronicStore
{
    class Product
    {
        protected string brand { get; set; }
        protected string model { get; set; }
        protected float price { get; set; }
        protected int amountInStock { get; set; }

        public Product()
        {
            this.brand = this.model = null;
            this.price = this.amountInStock = 0;
        }

        public Product(string brand, string model, float price, int amount)
        {
            this.brand = brand;
            this.model = model;
            this.price = price;
            this.amountInStock = amount;
        }
    }
}
