using Shop.Core.Entities;
using Shop.Core.Repositories;
using Shop.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Service
{
    public class ProductService: IProductService
    {
        private readonly IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public async Task<List<Product>> GetAllProductsAsync()
        {
            return await _productRepository.GetAllProductsAsync();
        }
        public async Task<List<Product>> GetProductsAsync(Kategory? kategory)
        {
            if (kategory != null)
            {
                var p = await _productRepository.GetProductsAsync();
                return p.FindAll(p => p.Kategory == kategory);
            }
            return await _productRepository.GetProductsAsync();
        }

        public async Task<Product> GetAsync(string barcode)
        {
            var p = await _productRepository.GetProductsAsync();
            return p.Find(p => p.Barcode == barcode);
        }
        public async Task<Product> PostAsync(Product product)
        {
            return await _productRepository.AddProductAsync(product);
        }
        public async Task<Product> PutAsync(string barcode, Product product)
        {
            return await _productRepository.PutProductAsync(barcode, product);
        }
        public void Delete(string barcode)
        {
            _productRepository.DeleteProduct(barcode);
        }
    }
}
