using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Shop.Api.Models;
using Shop.Core.Dtos;
using Shop.Core.Entities;
using Shop.Core.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Shop.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ICustomerService _customerService;
        public CustomerController(ICustomerService customerService, IMapper mapper)
        {
            _customerService = customerService;
            _mapper = mapper;
        }
        // GET: api/<CustomerController>
        [HttpGet]
        public async Task<ActionResult> GetAllCustomers()
        {
            var c = _mapper.Map<CustomerDto[]>(await _customerService.GetAllCustomersAsync());
            return Ok(c);
        }

        // GET api/<CustomerController>/5
        [HttpGet("{password}")]
        public async Task<ActionResult> GetCustomer(string password)
        {
            return Ok(_mapper.Map<CustomerDto>(await _customerService.GetCustomerAsync(password)));
        }

        // POST api/<CustomerController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] CustomerPostModel nCustomer)
        {
            var newCustomer = _mapper.Map<Customer>(nCustomer);
            var customer = await _customerService.AddAsync(newCustomer);
            return Ok(_mapper.Map<CustomerDto>(customer));
        }

        // PUT api/<CustomerController>/5
        [HttpPut("{password}")]
        public async Task<ActionResult> Put(string password, [FromBody] CustomerPostModel uCustomer)
        {
            var updateCustomer = _customerService.GetCustomerAsync(password).Result;
            var c = await _customerService.PutAsync(password, updateCustomer);
            return Ok(_mapper.Map<CustomerDto>(c));
        }

        // DELETE api/<CustomerController>/5
        [HttpDelete("{password}")]
        public ActionResult Delete(string password)
        {
            _customerService.Delete(password);
            return NoContent();
        }
    }
}
