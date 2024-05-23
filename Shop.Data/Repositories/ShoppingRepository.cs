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
    public class ShoppingRepository: IShoppingRepository
    {
        private readonly DataContext _context;

        public ShoppingRepository(DataContext context)
        {
            _context = context;
        }
        public async Task<List<Shopping>> GetShoppingsAsync()
        {
            return await _context.Shoppings.Include(u => u.Products).ToListAsync();
        }
        public async Task<Shopping> AddShoppingAsync(Shopping s)
        {
            _context.Shoppings.Add(s);
            await _context.SaveChangesAsync();
            //var sh = await _context.Shoppings.ToListAsync();
            //Shopping shopping = sh.Find(sho =>sho.Products==s.Products&&sho.PasswordCustomer==s.PasswordCustomer&&sho.DateTime==s.DateTime);
            return s;
        }
        public void DeleteShopping(int id)
        {
            var s = _context.Shoppings.Include(u => u.Products).ToList();
            var sh = s.Find(s => s.Id == id);
            if (sh != null)
            {
                _context.Shoppings.Remove(sh);
            }
            _context.SaveChanges();
        }
        public async Task<Shopping> PutAsync(int id, Shopping shopping)
        {
            var sh = await _context.Shoppings.ToListAsync();
            Shopping s = sh.Find(s => s.Id == id);
            if (s != null)
            {
                s.PasswordCustomer = shopping.PasswordCustomer;
                //s.Products = shopping.Products;
                s.PricePaying = shopping.PricePaying;
                s.Id = shopping.Id;
                s.DateTime = shopping.DateTime;
                await _context.SaveChangesAsync();
            }
            return shopping;
        }
    }
}
