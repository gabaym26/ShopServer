using Shop.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core.Services
{
    public interface IShoppingService
    {
        Task<List<Shopping>> GetShoppingsAsync(string? pass);
        Task<Shopping> GetAsync(int id);
        Task<Shopping> PostAsync(Shopping shopping);
        Task<Shopping> PutAsync(int id, Shopping shopping);
        void Delete(int id);
    }
}
