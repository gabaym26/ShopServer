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
    public class CustomerRepository: ICustomerRepository
    {
        private readonly DataContext _context;

        public CustomerRepository(DataContext context)
        {
            _context = context;
        }
        public async Task<Customer> PutAsync(string password, Customer updateCustomer)
        {
            Customer c = _context.Customers.ToList().Find(e => e.Password == password);
            if (c != null)
            {
                c.UserName = updateCustomer.UserName;
                c.Id = updateCustomer.Id;
                c.AshrayDetails = updateCustomer.AshrayDetails;
                await _context.SaveChangesAsync();
            }
            return c;
        }

        public async Task<List<Customer>> GetAllCustomerAsync()
        {
            return await _context.Customers.ToListAsync();
        }
        public async Task<Customer> AddAsync(Customer customer)
        {
            _context.Customers.Add(customer);
            await _context.SaveChangesAsync();
            return customer;
        }
        public void DeleteCustomer(string password)
        {
            var c = _context.Customers.ToList(); 
            var cu = c.Find(e => e.Password == password);
            if (cu!=null)
            {
                _context.Customers.Remove(cu);
            }
            _context.SaveChanges();
        }
    }
}
