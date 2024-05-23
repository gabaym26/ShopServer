using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Shop.Api.Models;
using Shop.Core.Dtos;
using Shop.Core.Entities;
using Shop.Core.Services;
using Shop.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Shop.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IProductService _productService;
        public ProductController(IProductService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<ActionResult> GetAllProducts()
        {
            var c = _mapper.Map<ProductDto[]>(await _productService.GetAllProductsAsync());
            return Ok(c);
        }
        // GET: api/<ProductController>
        [HttpGet("{kategory}")]
        public async Task<ActionResult> GetProducts(Kategory? kategory)
        {
            var products= await _productService.GetProductsAsync(kategory);
            return Ok(_mapper.Map<ProductDto[]>(products));
        }

        // GET api/<ProductController>/5
        [HttpGet("{barcode}")]
        public async Task<ActionResult> GetProduct(string barcode)
        {
            var p = await _productService.GetAsync(barcode);
            return Ok(_mapper.Map<ProductDto>(p));
        }

        // POST api/<ProductController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] ProductPostModel product)
        {
            var p = _mapper.Map<Product>(product);
            var newProduct = await _productService.PostAsync(p);
            return Ok(_mapper.Map<ProductDto>(newProduct));

        }

        // PUT api/<ProductController>/5
        [HttpPut("{barcode}")]
        public async Task<ActionResult> Put(string barcode, [FromBody] ProductPostModel product)
        {
            var p = _mapper.Map<Product>(product);
            var updateProduct = await _productService.PutAsync(barcode, p);
            return Ok(_mapper.Map<ProductDto>(updateProduct));
        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{barcode}")]
        public ActionResult Delete(string barcode)
        {
            _productService.Delete(barcode);
            return NoContent();
        }
    }
}
