﻿using System;
using Newtonsoft.Json;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create product object
            var product1 = new Product{ID = 101, Name = "Red Apple", Price=1.99};

            //Serialize the product object to JSON string
            var jsonString = JsonConvert.SerializeObject(product1);
            System.Console.WriteLine(jsonString);

            //Deserialize the JSON string to product object
            var product2 = JsonConvert.DeserializeObject<Product>(jsonString);
            System.Console.WriteLine($"The Product ID is {product2.ID}");
            System.Console.WriteLine($"The Product Name is {product2.Name}");
            System.Console.WriteLine($"The Product Price is {product2.Price}");
        }
    }

    class Product{
        public int ID{get;set;}
        public string Name{get;set;}
        public double Price{get;set;}
    }
}
