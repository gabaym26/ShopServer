using Shop.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core.Repositories
{
    public interface IShoppingRepository
    {
        Task<List<Shopping>> GetShoppingsAsync();
        Task<Shopping> AddShoppingAsync(Shopping s);
        void DeleteShopping(int id);
        Task<Shopping> PutAsync(int id, Shopping shopping);
    }
}
