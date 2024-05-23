using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core.Entities
{
    public enum Kategory { Milk, Meet, Cleaning, Baking, Cooking, Freezer }
    public class Product
    {
        //public int NumProductsExpect { get; set; }     
        //public int NumProductsExist { get; set; }
        public Kategory Kategory { get; set; }
        public int Id { get; set; }
        public string Barcode { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
    }
}
