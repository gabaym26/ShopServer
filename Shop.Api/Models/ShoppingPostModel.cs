using Shop.Core.Entities;

namespace Shop.Api.Models
{
    public class ShoppingPostModel
    {
        public List<ProductPostModel> Products { get; set; }
        public string PasswordCustomer { get; set; }
        public DateTime DateTime { get; set; }
    }
}
