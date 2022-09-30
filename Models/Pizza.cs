using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaShop7.Models
{
    public class Pizza
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string description { get; set; }
        public int Price { get; set; }
        public string Imageurl { get; set; }
    }
}