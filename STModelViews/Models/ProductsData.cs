using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace STModelViews.Models
{
    public class ProductsData
    {
        public IEnumerable<Product> ProductsList
        {
            get
            {
                List<Product> products = new List<Product>()
                {
                    new Product{ProductId=11,Name="IPhone",Price=120000},
                    new Product{ProductId=12,Name="Airpods",Price=25000},
                    new Product{ProductId=13,Name="Oneplus TV",Price=65000},
                    new Product{ProductId=14,Name="MacBook",Price=200000}
                };
                return products;
            }
        }
    }
}