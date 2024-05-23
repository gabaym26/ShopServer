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
    public class ShoppingService: IShoppingService
    {
        private readonly IShoppingRepository _shoppingRepository;
        public ShoppingService(IShoppingRepository shoppingRepository)
        {
            _shoppingRepository = shoppingRepository;
        }
        public async Task<List<Shopping>> GetShoppingsAsync(string? pass)
        {
            if (pass !=null)
            {
                var s = await _shoppingRepository.GetShoppingsAsync();
                s=s.FindAll(s => s.PasswordCustomer == pass);
                return s;
            }
            return await _shoppingRepository.GetShoppingsAsync();
        }
        public async Task<Shopping> GetAsync(int id)
        {
            var s = await _shoppingRepository.GetShoppingsAsync();
            return s.Find(s => s.Id == id);
        }
        public async Task<Shopping> PostAsync(Shopping shopping)
        {
            return await _shoppingRepository.AddShoppingAsync(shopping);
        }
        public async Task<Shopping> PutAsync(int id, Shopping shopping)
        {
            return await _shoppingRepository.PutAsync(id, shopping);
        }
        public async void Delete(int id)
        {
            _shoppingRepository.DeleteShopping(id);
        }
    }
}
