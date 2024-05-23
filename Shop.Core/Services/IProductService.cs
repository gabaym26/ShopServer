using Shop.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core.Services
{
    public interface IProductService
    {
        Task<List<Product>> GetAllProductsAsync();
        Task<List<Product>> GetProductsAsync(Kategory? kategory);
        Task<Product> GetAsync(string barcode);
        Task<Product> PostAsync(Product product);
        Task<Product> PutAsync(string barcode, Product product);
        void Delete(string barcode);
    }
}
