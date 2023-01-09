using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BeautyShopApp.Models;

namespace BeautyShopApp.Services
{
    public class ProductService
    {
        static ProductService _instance;
        public static ProductService Instance
        {
            get { return _instance ?? (_instance = new ProductService());}
        }

        public List<Product> GetProducts()
        {
            return new List<Product>
            {
                new Product
                {
                    Name = "Body Shimmer",
                    Image = "bodys.jpg",
                    Description = "Moisturizer body shimmer for a glowy skin",
                    Price = 50,
                },

                new Product
                {
                    Name = "Rimel",
                    Image = "rimel.png",
                    Description = "The perfect option for long lashes",
                    Price = 45.50,
                },
                new Product
                {
                    Name = "Blush",
                    Image = "images.jpg",
                    Description = "Liquid soft pinch blush",

                    Price = 100,
                },
                new Product
                {
                    Name = "Self-care packagae",
                    Image = "pachet.jpg",
                    Description = "The best skincare package for your daily routine",
                    Price = 250,

                },
                new Product
                {
                    Name = "Lipstick Nyx",
                    Image = "ruj.jpg",
                    Description = "The best lipstick for your night out",
                    Price = 45,
                },
                new Product
                {
                    Name = "Lipstick",
                    Image = "ruj1.jpg",
                    Description = "The perfect choice for your daily make-up routine",
                    Price = 30,
                },
                new Product
                {
                    Name = "Night Repair Serum",
                    Image = "ser.jpg",
                    Description = "NIght Reapar Serum",
                    Price = 350,
                },
            };
        }
    }
}
