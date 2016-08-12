using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebSecurityDemo.Models
{
    public class Products
    {
        public Product1 P1 { get; set; }

        public Product2 P2 { get; set; }
    }

    public class Product1
    {
        public string Id { get; set; }

        public Product1(string id)
        {
            Id = "ProductId:" + id + "|<textarea>";
        }
    }

    public class Product2
    {
        public string Id { get; set; }

        public Product2(string id)
        {
            Id = $"ProductId:{id}|<textarea>";
        }
    }

    public class Product3
    {
        public string Id { get; set; }

        public Product3(string id)
        {
            Id = id;
        }
    }
}