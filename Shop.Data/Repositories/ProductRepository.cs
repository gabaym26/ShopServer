using Microsoft.EntityFrameworkCore;
using Shop.Core.Entities;
using Shop.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Data.Repositories
{
    public class ProductRepository: IProductRepository
    {
        private readonly DataContext _context;

        public ProductRepository(DataContext context)
        {
            _context = context;
        }
        public async Task<List<Product>> GetAllProductsAsync()
        {
            return await _context.Products.ToListAsync();
        }
        public async Task<List<Product>> GetProductsAsync()
        {
            return await _context.Products.ToListAsync();
        }
        public async Task<Product> AddProductAsync(Product p)
        {
            _context.Products.Add(p);
            await _context.SaveChangesAsync();
            return p;
        }
        public async Task<Product> PutProductAsync(string barcode, Product n)
        {
            Product product = _context.Products.ToList().Find(pr => pr.Barcode == barcode);
            if (product != null)
            {
                //product.NumProductsExpect = n.NumProductsExpect;
                //product.NumProductsExist = n.NumProductsExist;
                product.Price = n.Price;
                product.Name = n.Name;
                product.Id = n.Id;
                product.Kategory = n.Kategory;
                await AddProductAsync(product);
                await _context.SaveChangesAsync();
            }
            return product;
        }

        public void DeleteProduct(string barcode)
        {
            var p = _context.Products.ToList();
            var pr = p.Find(p => p.Barcode == barcode);
            if (pr!=null)
            {
                _context.Products.Remove(pr);
            }         
            _context.SaveChanges();
        }

    }
}
