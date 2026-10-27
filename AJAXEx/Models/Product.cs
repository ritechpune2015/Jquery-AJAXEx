using System;
using System.Collections.Generic;

namespace AJAXEx.Models
{
    public class Product
    {
        public Int64    ProductID { get; set; }
        public string ProductName { get; set; }
        public string MfgName { get; set; }
        public decimal Price { get; set; }

        public static List<Product> GetProducts()
        {
            List<Product> lst = new List<Product>() {
            new Product()
            {
                ProductID=121,
                ProductName="Mouse",
                MfgName="Intex",
                Price=450
            },
            new Product()
            {
                ProductID=123,
                ProductName="Keyboard",
                MfgName="Logitech",
                Price=950
            },
            new Product()
            {
                ProductID=23,
                ProductName="Webcam",
                MfgName="Lenovo",
                Price=34550
            },
            new Product()
            {
                ProductID=89,
                ProductName="Monitor",
                MfgName="LG",
                Price=19000
            },
            new Product()
            {
                ProductID=189,
                ProductName="Cabinate",
                MfgName="Circle",
                Price=49000
            },
            new Product()
            {
                ProductID=459,
                ProductName="MotherBoard",
                MfgName="Asus",
                Price=35000
            }
         };

            return lst;
       }
    }
}
