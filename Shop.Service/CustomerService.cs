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
    public class CustomerService: ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;
        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }
        public async Task<List<Customer>> GetAllCustomersAsync()
        {
            return await _customerRepository.GetAllCustomerAsync();
        }
        public async Task<Customer> GetCustomerAsync(string password)
        {
            var customer = await _customerRepository.GetAllCustomerAsync();
            return customer.Find(c => c.Password == password);
        }
        public Task<Customer> AddAsync(Customer newCustomer)
        {
            return _customerRepository.AddAsync(newCustomer);
        }
        public async Task<Customer> PutAsync(string password, Customer updateCustomer)
        {
            return await _customerRepository.PutAsync(password, updateCustomer);
        }
        public void Delete(string password)
        {
            _customerRepository.DeleteCustomer(password);
        }
    }
}
