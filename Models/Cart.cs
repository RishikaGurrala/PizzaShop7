using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaShop7.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int Qty { get; set; }
        public int Price { get; set; }
    }
}