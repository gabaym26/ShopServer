using Shop.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core.Repositories
{
    public interface ICustomerRepository
    {
        Task<List<Customer>> GetAllCustomerAsync();
        Task<Customer> AddAsync(Customer customer);
        void DeleteCustomer(string password);
        Task<Customer> PutAsync(string password, Customer updateCustomer);

    }
}
