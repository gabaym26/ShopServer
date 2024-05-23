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
    public class ShoppingController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IShoppingService _shoppingService;
        public ShoppingController(IShoppingService shoppingService, IMapper mapper)
        {
            _shoppingService = shoppingService;
            _mapper = mapper;
        }
        // GET: api/<ShoppingController>
        [HttpGet]
        public async Task<ActionResult> GetShoppings(string? password)
        {
            return Ok(_mapper.Map<ShoppingDto[]>(await _shoppingService.GetShoppingsAsync(password)));
        }

        // GET api/<ShoppingController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            return Ok(_mapper.Map<ShoppingDto>(await _shoppingService.GetAsync(id)));
        }

        // POST api/<ShoppingController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] ShoppingPostModel shopping)
        {
            var s = _mapper.Map<Shopping>(shopping);
            var newShopping =await _shoppingService.PostAsync(s);
            return Ok(_mapper.Map<ShoppingDto>(newShopping));
        }

        // PUT api/<ShoppingController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] ShoppingPostModel shopping)
        {
            var s = _mapper.Map<Shopping>(shopping);
            var updateShopping =await _shoppingService.PutAsync(id, s);
            return Ok(_mapper.Map<ShoppingDto>(updateShopping));
        }

        // DELETE api/<ShoppingController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _shoppingService.Delete(id);
            return NoContent();
        }
    }
}
