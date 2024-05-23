using Shop.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core.Services
{
    public interface ICustomerService
    {
        Task<List<Customer>> GetAllCustomersAsync();
        Task<Customer> GetCustomerAsync(string password);
        Task<Customer> AddAsync(Customer newCustomer);
        Task<Customer> PutAsync(string password, Customer updateCustomer);
        void Delete(string password);
    }
}
