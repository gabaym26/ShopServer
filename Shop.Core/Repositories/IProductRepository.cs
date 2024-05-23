using Shop.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core.Repositories
{
    public interface IProductRepository
    {
        Task<List<Product>> GetAllProductsAsync();
        Task<List<Product>> GetProductsAsync();
        Task<Product> AddProductAsync(Product p);
        void DeleteProduct(string barcode);
        Task<Product> PutProductAsync(string barcode, Product n);

    }
}
