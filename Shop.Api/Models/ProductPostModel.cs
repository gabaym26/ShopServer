using Shop.Core.Entities;

namespace Shop.Api.Models
{
    public class ProductPostModel
    {
        public Kategory Kategory { get; set; }
        public string Barcode { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
    }
}
